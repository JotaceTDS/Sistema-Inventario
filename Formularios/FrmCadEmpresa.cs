using Inventario.Classes;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Formularios
{
    public partial class FrmCadEmpresa : Form
    {
        private int? idSelecionado = null;  

        public FrmCadEmpresa()
        {
            InitializeComponent();
                        
        }

        private void FrmCadEmpresa_Load(object sender, EventArgs e)
        {            
            BancoUtil.ExecutarConsulta
            (
                tabela: "empresa",
                grid: DgvEmpresas,
                colunas: "id, cnpj, ie, razao, fantasia, cep, endereco, bairro, cidade, uf, email, fone, contato",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "id ASC, razao ASC"
            );

            FormUtil.FormatarCodigo(DgvEmpresas);
            FormUtil.AplicarAvancoComEnter(this);
            DgvEmpresas.CellFormatting += DgvEmpresas_CellFormatting;
            FormatarGrid();
            
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, true);
            


            if (SessaoUsuario.EhAdmin)
            {                
                BtnNovo.Enabled = true;
                BtnSalvar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnExcluir.Enabled = false;
                return;
            }       
            
            TxtPesquisa.Enabled = true;
            //BtnNovo.Enabled = SessaoUsuario.EhAdmin;

        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CamposObrigatorios())
                return;

            string cnpj = FormUtil.RemoverMascara(txtCnpj.Text);           

            var campos = new Dictionary<string, object>
            {
                { "cnpj", cnpj },
                { "ie", FormUtil.RemoverMascara(txtIe.Text)},
                { "razao", txtRazao.Text },
                { "fantasia", txtFantasia.Text },
                { "cep", FormUtil.RemoverMascara(txtCep.Text)},
                { "endereco", txtEndereco.Text },
                { "bairro", txtBairro.Text },
                { "cidade", txtCidade.Text },
                { "uf", txtUf.Text },
                { "email", txtEmail.Text },
                { "fone", FormUtil.RemoverMascara(txtTelefone.Text) },
                { "contato", txtContato.Text }
            };

            if (idSelecionado == null)
            {
                bool cnpjDuplicado = BancoUtil.RegistroExiste("empresa", new Dictionary<string, object> { { "cnpj", cnpj } });
                if (cnpjDuplicado)
                {
                    MessageBox.Show("CNPJ já cadastrado. Por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCnpj.Focus();
                    return;
                }
                BancoUtil.InserirRegistro("empresa", campos);
                MessageBox.Show("Registro salvo com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool cnpjDuplicado = BancoUtil.EditarSemDuplicidade("empresa", new Dictionary<string, object> { { "cnpj", cnpj } }, "id", idSelecionado.Value);
                if (cnpjDuplicado)
                {
                    MessageBox.Show("CNPJ já cadastrado. Por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCnpj.Focus();
                    return;
                }
                BancoUtil.AtualizarRegistro("empresa", campos, "id", idSelecionado);
                MessageBox.Show("Registro atualizado com sucesso...!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            BancoUtil.ExecutarConsulta(
                tabela: "empresa",
                grid: DgvEmpresas,
                colunas: "id, cnpj, ie, razao, fantasia, cep, endereco, bairro, cidade, uf, email, fone, contato",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "id ASC, razao ASC"
            );

            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, true);
     
            FormatarGrid();
        }

   
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this);
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled = false;
            TxtPesquisa.Enabled = false;
            DgvEmpresas.ClearSelection(); // Limpa a seleção da grid
            DgvEmpresas.CurrentCell = null; // Remove o foco da grid
            idSelecionado = null; // Reseta o ID selecionado
            txtCnpj.Focus();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);            
            TxtPesquisa.Enabled = true;
            BtnNovo.Enabled = true;
            
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvEmpresas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir...!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            idSelecionado = Convert.ToInt32(DgvEmpresas.SelectedRows[0].Cells["id"].Value);

            DialogResult resposta = MessageBox.Show("Deseja excluir o registro selecionado?","Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)

            {
                var campos = new Dictionary<string, object>
                {
                     {"deletado", 1 }
                };
                BancoUtil.AtualizarRegistro("empresa", campos, "id", idSelecionado);                

                BancoUtil.ExecutarConsulta
                (
                    tabela: "empresa",
                    grid: DgvEmpresas,
                    colunas: "id, cnpj, ie, razao, fantasia, cep, endereco, bairro, cidade, uf, email, fone, contato",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "id ASC, razao ASC"
                );

                FormUtil.FormatarCodigo(DgvEmpresas);
                MessageBox.Show("Registro excluido com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormUtil.LimparCampos(this);
                FormUtil.HabilitarCampos(this, false);
                FormatarGrid();
            };
        }
     
        private void FormatarGrid()
        {
            var configuracoesEmpresas = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
            {
                { "id", ("Código", 50, true) }, // Essa será ocultada
                { "cnpj", ("CNPJ", 110, true) },
                { "ie", ("IE", 90, true) },
                { "razao", ("Razão Social", 150, true) },
                { "fantasia", ("Fantasia", 150, true) },
                { "cep", ("CEP", 100, true) },
                { "endereco", ("Endereço", 150, true) },
                { "bairro", ("Bairro", 100, true) },
                { "cidade", ("Cidade", 80, true) },
                { "uf", ("UF", 40, true) },
                { "email", ("E-mail", 150, true) },
                { "fone", ("Telefone", 100, true) },
                { "contato", ("Contato", 100, true) }
            };

            FormUtil.FormatarGridGenerico(DgvEmpresas, configuracoesEmpresas);
            FormUtil.FormatarCodigo(DgvEmpresas, "id");
            DgvEmpresas.RowHeadersVisible = false;

        }


        private void DgvEmpresas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvEmpresas.Rows[e.RowIndex].Cells["id"].Value != null)
        
            {
                DataGridViewRow row = DgvEmpresas.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);
                txtCnpj.Text = row.Cells["cnpj"].Value?.ToString();
                txtIe.Text = row.Cells["ie"].Value?.ToString();
                txtRazao.Text = row.Cells["razao"].Value?.ToString();
                txtFantasia.Text = row.Cells["fantasia"].Value?.ToString();
                txtCep.Text = row.Cells["cep"].Value?.ToString();               
                txtEndereco.Text = row.Cells["endereco"].Value?.ToString();
                txtBairro.Text = row.Cells["bairro"].Value?.ToString();
                txtCidade.Text = row.Cells["cidade"].Value?.ToString();
                txtUf.Text = row.Cells["uf"].Value?.ToString();
                txtEmail.Text = row.Cells["email"].Value?.ToString();
                txtTelefone.Text = row.Cells["fone"].Value?.ToString();
                txtContato.Text = row.Cells["contato"].Value?.ToString();

                FormUtil.HabilitarCampos(this);
                TxtPesquisa.Enabled = false;

                if (SessaoUsuario.EhAdmin)
                {
                    BtnNovo.Enabled = false;                
                    BtnCancelar.Enabled = true;                
                    return;
                }                
            }
        }
        private bool CamposObrigatorios()
        {
            var mensagens = new List<string>();

            if (string.IsNullOrWhiteSpace(txtCnpj.Text)) mensagens.Add("CNPJ");
            if (string.IsNullOrWhiteSpace(txtRazao.Text)) mensagens.Add("Razão Social");
            if (string.IsNullOrWhiteSpace(txtFantasia.Text)) mensagens.Add("Fantasia");

            if (mensagens.Count > 0)
            {
                MessageBox.Show("Preencha os campos obrigatórios: " + string.Join(", ", mensagens), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void DgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            TxtPesquisa.Enabled = true;
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string campo = "";

            if (rdbNome.Checked)
                campo = "razao";
            else if (rdbCpf.Checked)
                campo = "cnpj"; 

            if (string.IsNullOrEmpty(campo)) return;
            
            BancoUtil.PesquisarPorCampo("empresa", campo, TxtPesquisa.Text.Trim(), DgvEmpresas, "id, cnpj, ie, razao, fantasia, cep, endereco, bairro, cidade, uf, email, fone, contato");
            FormUtil.FormatarCodigo(DgvEmpresas);
        }
        private void DgvEmpresas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            string columnName = DgvEmpresas.Columns[e.ColumnIndex].Name;
            string valor = e.Value.ToString();

            var formatadores = new Dictionary<string, Func<string, string>>()
            {
                { "cnpj", FormUtil.FormatarCnpj },
                { "ie", FormUtil.FormatarIE },
                { "cep", FormUtil.FormatarCep },
                { "fone", FormUtil.FormatarTelefone }
            };

            if (formatadores.ContainsKey(columnName))
            {
                e.Value = formatadores[columnName](valor);
                e.FormattingApplied = true;
            }
        }

        private async void TxtCep_Leave(object sender, EventArgs e)
        {
            string cep = FormUtil.RemoverMascara(txtCep.Text);

            if (cep.Length != 8)
                return;

            var endereco = await Endereco.BuscaEnderecoPorCep(cep);

            if (endereco != null && string.IsNullOrEmpty(endereco.cep) == false)
            {
                txtEndereco.Text = endereco.logradouro;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.localidade;
                txtUf.Text = endereco.uf;
            }
            else
            {
                MessageBox.Show("CEP não encontrado ou inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
