using Inventario.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Inventario.Formularios
{
    public partial class FrmCadFuncionario : Form
    {
        private int? idSelecionado = null;

        public FrmCadFuncionario()
        {
            InitializeComponent();

            this.DgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFuncionarios_CellDoubleClick);

        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            
            BancoUtil.ExecutarConsulta
            (
                tabela: "funcionarios",
                grid: DgvFuncionarios,
                colunas: "id, empresa, nome, depto, email, fone,cpf, matricula, cargo, local",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "id ASC, empresa ASC, nome ASC"
            );

            BancoUtil.CarregarCombo(CmbCargo, "cargo", "id", "nome");
            BancoUtil.CarregarCombo(CmbEmpresa, "empresa", "id", "fantasia");
            BancoUtil.CarregarCombo(CmbPesquisa, "empresa", "id", "fantasia");
            FormUtil.FormatarCodigo(DgvFuncionarios, "id");
            
            FormUtil.AplicarAvancoComEnter(this);
            FormUtil.CarregarUFs(CmbLocal);
            DgvFuncionarios.CellFormatting += DgvFuncionarios_CellFormatting;
            FormatarGrid();
            FormUtil.HabilitarCampos(this, false);
            TxtPesquisa.Enabled = true;
            CmbPesquisa.Enabled = true;
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio())
            {
                return; 
            }          
            string cpf = FormUtil.RemoverMascara(TxtCpf.Text.Trim());

            var campos = new Dictionary<string, object>
            {
                {"nome", TxtNome.Text },
                {"empresa", CmbEmpresa.Text},
                {"depto", CmbDpto.Text },
                {"email", TxtEmail.Text},
                {"fone", FormUtil.RemoverMascara(TxtTelefone.Text) },
                {"cpf",  FormUtil.RemoverMascara(TxtCpf.Text) },
                {"matricula", TxtMatricula.Text},
                {"cargo", CmbCargo.Text},
                {"local", CmbLocal.Text},
            };
            if (idSelecionado == null)
            {
                bool cpfNaoZerado = !(cpf.All(c => c == '0'));
                bool existeCpf = cpfNaoZerado && BancoUtil.RegistroExiste("funcionarios", new Dictionary<string, object> { { "cpf", cpf } });

                if (existeCpf)
                {
                    MessageBox.Show("Já existe um funcionário cadastrado com este CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCpf.Focus();
                    return;
                }
                BancoUtil.InserirRegistro("funcionarios", campos);
                MessageBox.Show("Registro salvo com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool existeCpf = BancoUtil.EditarSemDuplicidade("funcionarios", new Dictionary<string, object> { { "cpf", cpf } },"id", idSelecionado.Value);
                if (existeCpf)
                {
                    MessageBox.Show("Já existe um funcionário cadastrado com este CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCpf.Focus();
                    return;
                }
                BancoUtil.AtualizarRegistro("funcionarios", campos, "id", idSelecionado);
                MessageBox.Show("Registro atualizado com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
            BancoUtil.ExecutarConsulta
            (
                tabela: "funcionarios",
                grid: DgvFuncionarios,
                colunas: "id, empresa, nome, depto, email, fone,cpf, matricula, cargo, local",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, nome ASC"
            );
            FormUtil.FormatarCodigo(DgvFuncionarios);
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            FormatarGrid();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this);
            BtnNovo.Enabled = false;
            TxtNome.Focus();
            TxtPesquisa.Enabled = false;
            CmbPesquisa.Enabled = false;
            DgvFuncionarios.ClearSelection();
            DgvFuncionarios.CurrentCell = null; // Remove seleção da célula
            idSelecionado = null; // Limpa o ID selecionado
        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            var filtrosObrigatorios = new Dictionary<string, object>();
                        
            if (!string.IsNullOrWhiteSpace(CmbPesquisa.Text))
                filtrosObrigatorios["empresa"] = CmbPesquisa.Text.Trim();
            
            BancoUtil.ExecutarConsulta
            (
                tabela: "funcionarios",
                grid: DgvFuncionarios,
                colunas: "id, empresa, nome, depto, email, fone,cpf, matricula, cargo, local",
                filtrosObrigatorios: filtrosObrigatorios,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, nome ASC"
            );
            BtnCancelar.Enabled = true;
        }
            

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormUtil.HabilitarCampos(this, false);
            FormUtil.LimparCampos(this);
            TxtPesquisa.Enabled = true;
            CmbPesquisa.Enabled = true;
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
            FormatarGrid();
        }

        private void DtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvFuncionarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir...!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }   

            idSelecionado = Convert.ToInt32(DgvFuncionarios.SelectedRows[0].Cells["id"].Value);
               
            DialogResult resposta = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (resposta == DialogResult.Yes)
                
            {
                var campos = new Dictionary<string, object>
                {
                    {"deletado", 1 }
                };

                BancoUtil.AtualizarRegistro("funcionarios", campos, "id", idSelecionado);
                
                BancoUtil.ExecutarConsulta
                (
                    tabela: "funcionarios",
                    grid: DgvFuncionarios,
                    colunas: "id, empresa, nome, depto, email, fone,cpf, matricula, cargo, local",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "empresa ASC, nome ASC"
                );

                FormUtil.FormatarCodigo(DgvFuncionarios);
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormUtil.LimparCampos(this);
                FormUtil.HabilitarCampos(this, false);
            }
        }

        private void DgvFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && DgvFuncionarios.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                
                DataGridViewRow row = DgvFuncionarios.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);

                TxtNome.Text = row.Cells["nome"].Value?.ToString();
                CmbEmpresa.Text = row.Cells["empresa"].Value?.ToString();
                CmbDpto.Text = row.Cells["depto"].Value?.ToString();
                TxtEmail.Text = row.Cells["email"].Value?.ToString();
                TxtTelefone.Text = row.Cells["fone"].Value?.ToString();
                TxtCpf.Text = row.Cells["cpf"].Value?.ToString();
                TxtMatricula.Text = row.Cells["matricula"].Value?.ToString();
                CmbCargo.Text = row.Cells["cargo"].Value?.ToString();
                CmbLocal.Text = row.Cells["local"].Value?.ToString();

                FormUtil.HabilitarCampos(this);
            }
        }

        private void FormatarGrid()
        {
            if (DgvFuncionarios.Columns.Count == 0)
                return;

            try
            {
                var configuracoesEmpresas = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
                {
                    { "id", ("Código", 50, true) },
                    { "nome", ("Nome", 150, true) },
                    { "empresa", ("Empresa", 130, true) },
                    { "depto", ("Departamento", 100, true) },
                    { "email", ("E-mail", 180, true) },
                    { "fone", ("Telefone", 90, true) },
                    { "cpf", ("CPF", 90, true) },
                    { "matricula", ("Matrícula", 60, true) },
                    { "cargo", ("Cargo", 100, true) },
                    { "local", ("Local", 40, true) }
                }
                ;
                FormUtil.FormatarGridGenerico(DgvFuncionarios, configuracoesEmpresas);
                DgvFuncionarios.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao formatar o grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                    
        }

        private bool CampoObrigatorio()
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text) ||
                string.IsNullOrWhiteSpace(TxtCpf.Text) ||
                string.IsNullOrWhiteSpace(CmbEmpresa.Text) ||
                string.IsNullOrWhiteSpace(CmbDpto.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios...!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var cpf = FormUtil.RemoverMascara(TxtCpf.Text);
            if (cpf.Length != 11)
            {
                MessageBox.Show("CPF invalido...!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void DgvFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)        
        {
  
            if (DgvFuncionarios.Columns[e.ColumnIndex].Name == "cpf" && e.Value != null)
            {
                e.Value = FormUtil.FormatarCPFString(e.Value.ToString());
                e.FormattingApplied = true;
            }
            else if (DgvFuncionarios.Columns[e.ColumnIndex].Name == "fone" && e.Value != null)
            {
                e.Value = FormUtil.FormatarTelefone(e.Value.ToString());
                e.FormattingApplied = true;
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // monta filtros obrigatórios (empresa só se estiver preenchida)
            var filtrosObrigatorios = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(CmbPesquisa.Text))
                filtrosObrigatorios["empresa"] = CmbPesquisa.Text.Trim();

            // monta filtros opcionais
            var filtrosOpcionais = new Dictionary<string, string>();

            string texto = TxtPesquisa.Text.Trim();
            string campo = "";

            if (RdbNome.Checked) campo = "nome";
            else if (RdbCpf.Checked) campo = "cpf";

            if (!string.IsNullOrEmpty(campo) && !string.IsNullOrEmpty(texto))
            {
                if (campo == "nome")
                {
                    // LIKE para nome
                    filtrosOpcionais[campo] = $"%{texto}%";
                }
                else if (campo == "cpf")
                {
                    // remove máscara e aplica LIKE
                    string cpfSemMascara = FormUtil.RemoverMascara(texto);
                    filtrosOpcionais[campo] = $"%{cpfSemMascara}%";
                }               
            }

            // executa a consulta
            BancoUtil.ExecutarConsulta(
                tabela: "funcionarios",
                grid: DgvFuncionarios,
                colunas: "id, nome, empresa, depto, email, fone, cpf, matricula, cargo, local",
                filtrosObrigatorios: filtrosObrigatorios,
                filtrosOpcionais: filtrosOpcionais,
                orderBy: "empresa ASC, nome ASC"
            );

            FormUtil.FormatarCodigo(DgvFuncionarios);
        }
        private void DgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
        }
       
    }
}


