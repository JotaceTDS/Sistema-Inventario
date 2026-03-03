using DocumentFormat.OpenXml.Drawing.Diagrams;
using Inventario.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Formularios
{
    public partial class FrmCadAcesso : Form
    {
        private int? idSelecionado = null;
        public FrmCadAcesso()
        {
            InitializeComponent();
        }

        private void FrmCadAcesso_Load(object sender, EventArgs e)
        {
            BancoUtil.ExecutarConsulta
            (
                tabela: "acesso",
                grid: DgvAcesso,
                colunas: "id, empresa, fornecedor, link, login, senha",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa, fornecedor"
            );
            DgvAcesso.ClearSelection();
            BancoUtil.CarregarCombo(CmbEmpresa, "empresa", "id", "fantasia");
            BancoUtil.CarregarCombo(CmbFornece, "fornecedor", "id", "fantasia");
            FormUtil.FormatarCodigo(DgvAcesso, "id");
            FormUtil.AplicarAvancoComEnter(this);            
            FormUtil.HabilitarCampos(this, false);        
            FormUtil.AplicarPermissoes(this);
            FormatarGrid();
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
            TxtPesquisa.Enabled = true;


        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, true);
            CmbEmpresa.Focus();
            DgvAcesso.ClearSelection();
            DgvAcesso.CurrentCell = null;
            idSelecionado = null;
            TxtPesquisa.Enabled = false;
            
            BtnNovo.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CamposObrigatorio())
            {
                BtnNovo.Enabled = false;
                return;
            }

            var filtroDuplicidade = new Dictionary<string, object>
            {
                { "empresa", CmbEmpresa.Text },
                { "fornecedor", CmbFornece.Text },
                { "link", TxtLink.Text },
                { "login", TxtLogin.Text },
                { "senha", TxtSenha.Text }
            };
            if (idSelecionado == null && BancoUtil.RegistroExiste("acesso", filtroDuplicidade))
            {
                MessageBox.Show("Já existe um acesso cadastrado com os mesmos dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var campos = new Dictionary<string, object>
            {
                { "empresa", CmbEmpresa.Text },
                { "fornecedor", CmbFornece.Text },
                { "link", TxtLink.Text },
                { "login", TxtLogin.Text },
                { "senha", TxtSenha.Text }
            };

            if (idSelecionado == null)
            {
                BancoUtil.InserirRegistro("acesso", campos);
                MessageBox.Show("Acesso cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BancoUtil.AtualizarRegistro("acesso", campos, "id", idSelecionado);
                MessageBox.Show("Acesso atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK);
            }

            BancoUtil.ExecutarConsulta
            (
                tabela: "acesso",
                grid: DgvAcesso,
                colunas: "id, empresa, fornecedor, link, login, senha",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa, fornecedor"
            );

            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            FormatarGrid();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
            TxtPesquisa.Enabled = true;             
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvAcesso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um acesso para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            idSelecionado = Convert.ToInt32(DgvAcesso.SelectedRows[0].Cells["id"].Value);
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o acesso selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resposta == DialogResult.Yes)
            {
                var campos = new Dictionary<string, object>
                {
                    { "deletado", 1 }
                };

                BancoUtil.AtualizarRegistro("acesso", campos, "id", idSelecionado);

                BancoUtil.ExecutarConsulta
                (
                    tabela: "acesso",
                    grid: DgvAcesso,
                    colunas: "id, empresa, fornecedor, link, login, senha",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "empresa, fornecedor"
                );
                FormUtil.LimparCampos(this);
                FormUtil.HabilitarCampos(this, false);
                FormatarGrid();
            }
        }

        private bool CamposObrigatorio()
        {
            if (string.IsNullOrWhiteSpace(CmbEmpresa.Text) ||
                string.IsNullOrWhiteSpace(CmbFornece.Text) ) 
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtLink.Text) ||
                string.IsNullOrWhiteSpace(TxtLogin.Text) ||
                string.IsNullOrWhiteSpace(TxtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;                    
        }

        private void FormatarGrid()
        {
            if (DgvAcesso.Columns.Count == 0)
                return;
            try
            {
                var configuracoesAcesso = new Dictionary<string, (string Titulo, int Largura, bool visible)>
                {
                    { "id", ("Codigo", 50, true) },
                    { "empresa", ("Empresa", 150, true) },
                    { "fornecedor", ("Fornecedor", 150, true) },
                    { "link", ("Link", 200, true) },
                    { "login", ("Login", 100, true) },
                    { "senha", ("Senha", 100, true) }
                };
                
                FormUtil.FormatarGridGenerico(DgvAcesso, configuracoesAcesso);
                FormUtil.FormatarCodigo(DgvAcesso, "id");
                DgvAcesso.RowHeadersVisible = false;

                if (DgvAcesso.Columns.Contains("link"))
                {
                    DgvAcesso.Columns["link"].DefaultCellStyle.ForeColor = Color.Blue;
                    DgvAcesso.Columns["link"].DefaultCellStyle.Font = new Font(DgvAcesso.Font, FontStyle.Underline);
                    DgvAcesso.Cursor = Cursors.Hand;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao formatar grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        //private void LimparCampos()
        //{
        //    CmbEmpresa.SelectedIndex = -1;
        //    CmbFornece.SelectedIndex = -1;
        //    TxtLink.Clear();
        //    TxtLogin.Clear();
        //    TxtSenha.Clear();
        //}

        private void DgvAcesso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvAcesso.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um acesso para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex >= 0 && DgvAcesso.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow  row = DgvAcesso.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(DgvAcesso.Rows[e.RowIndex].Cells["id"].Value);
                CmbEmpresa.Text = DgvAcesso.Rows[e.RowIndex].Cells["empresa"].Value.ToString();
                CmbFornece.Text = DgvAcesso.Rows[e.RowIndex].Cells["fornecedor"].Value.ToString();
                TxtLink.Text = DgvAcesso.Rows[e.RowIndex].Cells["link"].Value.ToString();
                TxtLogin.Text = DgvAcesso.Rows[e.RowIndex].Cells["login"].Value.ToString();
                TxtSenha.Text = DgvAcesso.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                FormUtil.HabilitarCampos(this, true);
                FormUtil.AplicarPermissoes(this);
                TxtPesquisa.Enabled = false;
                BtnNovo.Enabled = false;
            }
        }

        private void DgvAcesso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 00 && DgvAcesso.Columns[e.ColumnIndex].Name == "link")
            {
                string url = DgvAcesso.Rows[e.RowIndex].Cells["link"].Value.ToString();
                string login = DgvAcesso.Rows[e.RowIndex].Cells["login"].Value.ToString();
                string senha = DgvAcesso.Rows[e.RowIndex].Cells["senha"].Value.ToString();

                if (!String.IsNullOrEmpty(url))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });

                        Clipboard.SetText(senha);
                       // MessageBox.Show($"Abrindo site...\N0 login é {login}\nA senha ja foi copiado para a área de transferência.", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MessageBox.Show($"Site aberto!\nLogin: {login}\nA senha ja foi copiado para a área de transferência.",
                        "Automação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível abrir o link: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }
    }
}
