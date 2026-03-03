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
using System.Reflection;


namespace Inventario.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFuncionario frm = new FrmCadFuncionario();
            frm.ShowDialog();

        }

        private void MnuUsuarios_Click(object sender, EventArgs e)
        {
            FrmCadUsers frm = new FrmCadUsers();
            frm.ShowDialog();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string versaoProduto = Application.ProductVersion;
            toolStripStatusLabel1.Text = "Versão: " + versaoProduto;

            lblUsuario.Text = SessaoUsuario.Nome;

            if (SessaoUsuario.Acesso != "Administrador")
            {
                MnuUsuarios.Enabled = false;                
            }
        }

        private void MnuEmpresas_Click(object sender, EventArgs e)
        {
            FrmCadEmpresa frm = new FrmCadEmpresa();
            frm.ShowDialog();

        }

        private void MnuFuncoes_Click(object sender, EventArgs e)
        {
            FrmCargo frm = new FrmCargo();
            frm.ShowDialog();

        }

        private void MnuLinhas_Click(object sender, EventArgs e)
        {
            FrmCadFone frm = new FrmCadFone();
            frm.ShowDialog();

        }

        private void MnuFornecedor_Click(object sender, EventArgs e)
        {
            FrmCadFornecedor frm = new FrmCadFornecedor();
            frm.ShowDialog();

        }

        private void MnuProdutos_Click(object sender, EventArgs e)
        {
            FrmCadProduto frm = new FrmCadProduto();
            frm.ShowDialog();
        }

        private void MnuEstoque_Click(object sender, EventArgs e)
        {
            FrmEstoque frm = new FrmEstoque();
            frm.ShowDialog();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("Deseja realmente sair ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                SessaoUsuario.Limpar();
                this.Hide();

                Frmlogin login = new Frmlogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void controleDeLicençasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicosTi frm = new FrmServicosTi();
            frm.ShowDialog();

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorios frm = new FrmRelatorios();
            frm.ShowDialog();
        }


        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadDpto frm = new FrmCadDpto();
            frm.ShowDialog();
        }

        private void acessoComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadAcesso frm = new FrmCadAcesso();
            frm.ShowDialog();
        }
    }
}
