using Inventario.Classes;
using Inventario.Formularios;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using AutoUpdaterDotNET;

namespace Inventario 
{
    public partial class Frmlogin : Form
    {
        // Cores baseadas na paleta da Epitychia
        private Color primaryGreen = Color.FromArgb(46, 204, 113);
        private Color lightGreen = Color.FromArgb(39, 174, 96);
        private Color backgroundColor = Color.FromArgb(236, 240, 241);
        private Color textColor = Color.FromArgb(44, 62, 80);
        private Color lightGray = Color.FromArgb(189, 195, 199);

        public Frmlogin()
        {
            InitializeComponent();                        
            this.BackColor = Color.White;           

        }
    
        private void TextBox_Paint(object sender, PaintEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, textBox.Width - 1, textBox.Height - 1);
            using (GraphicsPath path = GetRoundedRectanglePath(rect, 8))
            {
                using (Pen pen = new Pen(lightGray, 1))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private void LoginButton_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);
            using (GraphicsPath path = GetRoundedRectanglePath(rect, 8))
            {
                Color buttonColor = button.BackColor;
                if (button.ClientRectangle.Contains(button.PointToClient(Cursor.Position)))
                {
                    buttonColor = lightGreen;
                }

                using (SolidBrush brush = new SolidBrush(buttonColor))
                {
                    g.FillPath(brush, path);
                }
            }

            using (SolidBrush textBrush = new SolidBrush(button.ForeColor))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(button.Text, button.Font, textBrush, button.ClientRectangle, sf);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {

                MessageBox.Show("Informe usuário e senha.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Certifique-se de que BancoUtil.AutenticarUsuario está acessível e funcional
            DataRow usuario_log = BancoUtil.AutenticarUsuario(usuario, senha);

            if (usuario_log != null)
            {
                SessaoUsuario.Id = Convert.ToInt32(usuario_log["id"]);
                SessaoUsuario.Nome = usuario_log["usuario"].ToString();
                SessaoUsuario.Acesso = usuario_log["acesso"].ToString();
                SessaoUsuario.Empresas = usuario_log["empresas"].ToString();

                MessageBox.Show($"Bem-vindo, {SessaoUsuario.Nome}!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmPrincipal frm = new FrmPrincipal();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void ArredondarBordas(int raio)
        {
            GraphicsPath path = new GraphicsPath();

            // desenha um retângulo com cantos arredondados
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, raio, raio), 180, 90);
            path.AddLine(raio, 0, this.Width - raio, 0);
            path.AddArc(new Rectangle(this.Width - raio, 0, raio, raio), -90, 90);
            path.AddLine(this.Width, raio, this.Width, this.Height - raio);
            path.AddArc(new Rectangle(this.Width - raio, this.Height - raio, raio, raio), 0, 90);
            path.AddLine(this.Width - raio, this.Height, raio, this.Height);
            path.AddArc(new Rectangle(0, this.Height - raio, raio, raio), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        // Atualiza ao redimensionar o formulário
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ArredondarBordas(20);
        }




        private void Frmlogin_Load_1(object sender, EventArgs e)
        {
            AutoUpdater.AppTitle = "Controle de Inventário";
            AutoUpdater.OpenDownloadPage = false;     // baixa e executa direto
            AutoUpdater.RunUpdateAsAdmin = true;      // necessário para instalar updates
            AutoUpdater.DownloadPath = System.IO.Path.GetTempPath();
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;

            try
            {
                string caminhoBase = Conexao.CaminhoSistema; // Ex: C:\Sistema
                string caminhoXml = System.IO.Path.Combine(caminhoBase, "Atualizacoes", "controleinventario.xml");

                // Converte caminho local para formato UNC (rede)
                string caminhoRede = caminhoXml.Replace(@"C:\", @"\\172.16.250.4\").Replace(@"\", "/");

                AutoUpdater.Start($"file://///{caminhoRede}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar atualizações: {ex.Message}", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FormUtil.AplicarAvancoComEnter(this);
            txtUsuario.Focus();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
