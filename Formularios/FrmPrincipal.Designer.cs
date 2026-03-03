namespace Inventario.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.CadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFuncoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLinhas = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeLicençasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.acessoComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerData
            // 
            this.timerData.Enabled = true;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrosToolStripMenuItem,
            this.ProdutosToolStripMenuItem,
            this.MnuRelatorios,
            this.MnuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuPrincipal.Size = new System.Drawing.Size(1282, 33);
            this.menuPrincipal.TabIndex = 11;
            this.menuPrincipal.Text = "MenuStrip1";
            // 
            // CadastrosToolStripMenuItem
            // 
            this.CadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoComprasToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.MnuEmpresas,
            this.MnuFornecedor,
            this.MnuFuncionarios,
            this.MnuFuncoes,
            this.MnuProdutos,
            this.MnuUsuarios});
            this.CadastrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.CadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CadastrosToolStripMenuItem.Image")));
            this.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem";
            this.CadastrosToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.CadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // MnuEmpresas
            // 
            this.MnuEmpresas.Name = "MnuEmpresas";
            this.MnuEmpresas.Size = new System.Drawing.Size(205, 28);
            this.MnuEmpresas.Text = "Empresas";
            this.MnuEmpresas.Click += new System.EventHandler(this.MnuEmpresas_Click);
            // 
            // MnuFornecedor
            // 
            this.MnuFornecedor.Name = "MnuFornecedor";
            this.MnuFornecedor.Size = new System.Drawing.Size(205, 28);
            this.MnuFornecedor.Text = "Fornecedor";
            this.MnuFornecedor.Click += new System.EventHandler(this.MnuFornecedor_Click);
            // 
            // MnuFuncionarios
            // 
            this.MnuFuncionarios.Name = "MnuFuncionarios";
            this.MnuFuncionarios.Size = new System.Drawing.Size(205, 28);
            this.MnuFuncionarios.Text = "Funcionários";
            this.MnuFuncionarios.Click += new System.EventHandler(this.FuncionáriosToolStripMenuItem_Click);
            // 
            // MnuFuncoes
            // 
            this.MnuFuncoes.Name = "MnuFuncoes";
            this.MnuFuncoes.Size = new System.Drawing.Size(205, 28);
            this.MnuFuncoes.Text = "Funções";
            this.MnuFuncoes.Click += new System.EventHandler(this.MnuFuncoes_Click);
            // 
            // MnuProdutos
            // 
            this.MnuProdutos.Name = "MnuProdutos";
            this.MnuProdutos.Size = new System.Drawing.Size(205, 28);
            this.MnuProdutos.Text = "Produtos";
            this.MnuProdutos.Click += new System.EventHandler(this.MnuProdutos_Click);
            // 
            // MnuUsuarios
            // 
            this.MnuUsuarios.Name = "MnuUsuarios";
            this.MnuUsuarios.Size = new System.Drawing.Size(205, 28);
            this.MnuUsuarios.Text = "Usuarios";
            this.MnuUsuarios.Click += new System.EventHandler(this.MnuUsuarios_Click);
            // 
            // ProdutosToolStripMenuItem
            // 
            this.ProdutosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEstoque,
            this.MnuLinhas,
            this.controleDeLicençasToolStripMenuItem});
            this.ProdutosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.ProdutosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProdutosToolStripMenuItem.Image")));
            this.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem";
            this.ProdutosToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.ProdutosToolStripMenuItem.Text = "Controle";
            // 
            // MnuEstoque
            // 
            this.MnuEstoque.Name = "MnuEstoque";
            this.MnuEstoque.Size = new System.Drawing.Size(238, 28);
            this.MnuEstoque.Text = "Controle de Estoque";
            this.MnuEstoque.Click += new System.EventHandler(this.MnuEstoque_Click);
            // 
            // MnuLinhas
            // 
            this.MnuLinhas.Name = "MnuLinhas";
            this.MnuLinhas.Size = new System.Drawing.Size(238, 28);
            this.MnuLinhas.Text = "Controle de Linhas";
            this.MnuLinhas.Click += new System.EventHandler(this.MnuLinhas_Click);
            // 
            // controleDeLicençasToolStripMenuItem
            // 
            this.controleDeLicençasToolStripMenuItem.Name = "controleDeLicençasToolStripMenuItem";
            this.controleDeLicençasToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.controleDeLicençasToolStripMenuItem.Text = "Controle de Licenças";
            this.controleDeLicençasToolStripMenuItem.Click += new System.EventHandler(this.controleDeLicençasToolStripMenuItem_Click);
            // 
            // MnuRelatorios
            // 
            this.MnuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.linhasToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.MnuRelatorios.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.MnuRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("MnuRelatorios.Image")));
            this.MnuRelatorios.Name = "MnuRelatorios";
            this.MnuRelatorios.Size = new System.Drawing.Size(117, 27);
            this.MnuRelatorios.Text = "Relatórios";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // linhasToolStripMenuItem
            // 
            this.linhasToolStripMenuItem.Name = "linhasToolStripMenuItem";
            this.linhasToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.linhasToolStripMenuItem.Text = "Linhas";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // MnuSair
            // 
            this.MnuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogoutToolStripMenuItem});
            this.MnuSair.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.MnuSair.Image = ((System.Drawing.Image)(resources.GetObject("MnuSair.Image")));
            this.MnuSair.Name = "MnuSair";
            this.MnuSair.Size = new System.Drawing.Size(70, 27);
            this.MnuSair.Text = "Sair";
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.LogoutToolStripMenuItem.Text = "Logout";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Location = new System.Drawing.Point(1107, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 77);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Funcionario";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Location = new System.Drawing.Point(7, 32);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(63, 19);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Usuario:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Location = new System.Drawing.Point(6, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 19);
            this.Label1.TabIndex = 7;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(79, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 19);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Label1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 751);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1282, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // acessoComprasToolStripMenuItem
            // 
            this.acessoComprasToolStripMenuItem.Name = "acessoComprasToolStripMenuItem";
            this.acessoComprasToolStripMenuItem.Size = new System.Drawing.Size(205, 28);
            this.acessoComprasToolStripMenuItem.Text = "Acesso Compras";
            this.acessoComprasToolStripMenuItem.Click += new System.EventHandler(this.acessoComprasToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 773);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Timer timerData;
        internal System.Windows.Forms.ToolStripMenuItem CadastrosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MnuFuncionarios;
        internal System.Windows.Forms.ToolStripMenuItem MnuEmpresas;
        internal System.Windows.Forms.ToolStripMenuItem MnuFuncoes;
        internal System.Windows.Forms.ToolStripMenuItem MnuFornecedor;
        internal System.Windows.Forms.ToolStripMenuItem MnuProdutos;
        internal System.Windows.Forms.ToolStripMenuItem MnuUsuarios;
        internal System.Windows.Forms.ToolStripMenuItem ProdutosToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem MnuEstoque;
        internal System.Windows.Forms.ToolStripMenuItem MnuLinhas;
        internal System.Windows.Forms.ToolStripMenuItem MnuRelatorios;
        internal System.Windows.Forms.ToolStripMenuItem MnuSair;
        internal System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip menuPrincipal;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem controleDeLicençasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoComprasToolStripMenuItem;
    }
}