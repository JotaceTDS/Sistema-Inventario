namespace Inventario.Formularios
{
    partial class FrmCadFone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFone));
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.DgvTelefones = new System.Windows.Forms.DataGridView();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtVigPlano = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.RdbNome = new System.Windows.Forms.RadioButton();
            this.RdbLinha = new System.Windows.Forms.RadioButton();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtVencimento = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbPesquisa = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.CmbEmpresa = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.CmbNome = new System.Windows.Forms.ComboBox();
            this.CmbTpChip = new System.Windows.Forms.ComboBox();
            this.CmbSituacao = new System.Windows.Forms.ComboBox();
            this.CmbConta = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CmbDados = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.CmbOpera = new System.Windows.Forms.ComboBox();
            this.TxtLinha = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTelefones)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.SystemColors.Window;
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.Enabled = false;
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnNovo.Location = new System.Drawing.Point(39, 599);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(103, 37);
            this.BtnNovo.TabIndex = 109;
            this.BtnNovo.Text = "&Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnExcluir.Location = new System.Drawing.Point(890, 599);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 37);
            this.BtnExcluir.TabIndex = 112;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Window;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(602, 599);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(103, 37);
            this.BtnCancelar.TabIndex = 111;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnSalvar.Location = new System.Drawing.Point(328, 599);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(103, 37);
            this.BtnSalvar.TabIndex = 110;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // DgvTelefones
            // 
            this.DgvTelefones.AllowUserToAddRows = false;
            this.DgvTelefones.AllowUserToDeleteRows = false;
            this.DgvTelefones.BackgroundColor = System.Drawing.Color.MintCream;
            this.DgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTelefones.Location = new System.Drawing.Point(12, 304);
            this.DgvTelefones.Name = "DgvTelefones";
            this.DgvTelefones.ReadOnly = true;
            this.DgvTelefones.RowHeadersWidth = 62;
            this.DgvTelefones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTelefones.Size = new System.Drawing.Size(1001, 266);
            this.DgvTelefones.TabIndex = 115;
            this.DgvTelefones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTelefones_CellClick);
            this.DgvTelefones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTelefones_CellDoubleClick);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label4.Location = new System.Drawing.Point(20, 81);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 19);
            this.Label4.TabIndex = 113;
            this.Label4.Text = "N° Linha:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.AutoSize = true;
            this.GroupBox1.Controls.Add(this.groupBox4);
            this.GroupBox1.Controls.Add(this.TxtVigPlano);
            this.GroupBox1.Controls.Add(this.label12);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label18);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.TxtVencimento);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.TxtValor);
            this.GroupBox1.Controls.Add(this.CmbEmpresa);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.CmbNome);
            this.GroupBox1.Controls.Add(this.CmbTpChip);
            this.GroupBox1.Controls.Add(this.CmbSituacao);
            this.GroupBox1.Controls.Add(this.CmbConta);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.CmbDados);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.CmbOpera);
            this.GroupBox1.Controls.Add(this.TxtLinha);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GroupBox1.Location = new System.Drawing.Point(12, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(1001, 286);
            this.GroupBox1.TabIndex = 116;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Cadastro:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.groupBox4.Location = new System.Drawing.Point(699, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 91);
            this.groupBox4.TabIndex = 119;
            this.groupBox4.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 86;
            this.label13.Text = "Total da conta:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 85;
            this.label10.Text = "Total de linhas:";
            // 
            // TxtVigPlano
            // 
            this.TxtVigPlano.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtVigPlano.Location = new System.Drawing.Point(16, 231);
            this.TxtVigPlano.Mask = "00/00/0000";
            this.TxtVigPlano.Name = "TxtVigPlano";
            this.TxtVigPlano.Size = new System.Drawing.Size(111, 26);
            this.TxtVigPlano.TabIndex = 118;
            this.TxtVigPlano.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label12.Location = new System.Drawing.Point(21, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 19);
            this.label12.TabIndex = 117;
            this.label12.Text = "Vigencia:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label7.Location = new System.Drawing.Point(176, 139);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(78, 19);
            this.Label7.TabIndex = 115;
            this.Label7.Text = "Operadora:";
            // 
            // Label18
            // 
            this.Label18.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label18.ForeColor = System.Drawing.Color.Red;
            this.Label18.Location = new System.Drawing.Point(78, 23);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(11, 11);
            this.Label18.TabIndex = 114;
            this.Label18.Text = "*";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label6.Location = new System.Drawing.Point(525, 80);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(63, 19);
            this.Label6.TabIndex = 97;
            this.Label6.Text = "Situação:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.RdbNome);
            this.GroupBox2.Controls.Add(this.RdbLinha);
            this.GroupBox2.Controls.Add(this.TxtPesquisa);
            this.GroupBox2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GroupBox2.Location = new System.Drawing.Point(699, 86);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(288, 80);
            this.GroupBox2.TabIndex = 109;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Buscar";
            // 
            // RdbNome
            // 
            this.RdbNome.AutoSize = true;
            this.RdbNome.BackColor = System.Drawing.Color.Transparent;
            this.RdbNome.Checked = true;
            this.RdbNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbNome.Location = new System.Drawing.Point(15, 19);
            this.RdbNome.Name = "RdbNome";
            this.RdbNome.Size = new System.Drawing.Size(63, 20);
            this.RdbNome.TabIndex = 91;
            this.RdbNome.TabStop = true;
            this.RdbNome.Text = "Nome:";
            this.RdbNome.UseVisualStyleBackColor = false;
            // 
            // RdbLinha
            // 
            this.RdbLinha.AutoSize = true;
            this.RdbLinha.BackColor = System.Drawing.Color.Transparent;
            this.RdbLinha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbLinha.Location = new System.Drawing.Point(15, 50);
            this.RdbLinha.Name = "RdbLinha";
            this.RdbLinha.Size = new System.Drawing.Size(78, 20);
            this.RdbLinha.TabIndex = 93;
            this.RdbLinha.Text = "Nº Linha:";
            this.RdbLinha.UseVisualStyleBackColor = false;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(119, 29);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(141, 26);
            this.TxtPesquisa.TabIndex = 92;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label8.Location = new System.Drawing.Point(177, 79);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 19);
            this.Label8.TabIndex = 104;
            this.Label8.Text = "Conta:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label2.Location = new System.Drawing.Point(371, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 19);
            this.Label2.TabIndex = 84;
            this.Label2.Text = "Usuario";
            // 
            // TxtVencimento
            // 
            this.TxtVencimento.Enabled = false;
            this.TxtVencimento.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtVencimento.Location = new System.Drawing.Point(371, 159);
            this.TxtVencimento.Name = "TxtVencimento";
            this.TxtVencimento.Size = new System.Drawing.Size(84, 26);
            this.TxtVencimento.TabIndex = 113;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label11.Location = new System.Drawing.Point(369, 138);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(81, 19);
            this.Label11.TabIndex = 112;
            this.Label11.Text = "Vencimento";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.CmbPesquisa);
            this.GroupBox3.Controls.Add(this.BtnFiltrar);
            this.GroupBox3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GroupBox3.Location = new System.Drawing.Point(699, 11);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(288, 70);
            this.GroupBox3.TabIndex = 111;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Filtrar por empresas";
            // 
            // CmbPesquisa
            // 
            this.CmbPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPesquisa.FormattingEnabled = true;
            this.CmbPesquisa.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.CmbPesquisa.Location = new System.Drawing.Point(11, 30);
            this.CmbPesquisa.Name = "CmbPesquisa";
            this.CmbPesquisa.Size = new System.Drawing.Size(159, 24);
            this.CmbPesquisa.TabIndex = 115;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Location = new System.Drawing.Point(200, 29);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(82, 23);
            this.BtnFiltrar.TabIndex = 109;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // TxtValor
            // 
            this.TxtValor.Enabled = false;
            this.TxtValor.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtValor.Location = new System.Drawing.Point(520, 158);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(109, 26);
            this.TxtValor.TabIndex = 9;
            // 
            // CmbEmpresa
            // 
            this.CmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmpresa.Enabled = false;
            this.CmbEmpresa.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbEmpresa.FormattingEnabled = true;
            this.CmbEmpresa.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.CmbEmpresa.Location = new System.Drawing.Point(16, 41);
            this.CmbEmpresa.Name = "CmbEmpresa";
            this.CmbEmpresa.Size = new System.Drawing.Size(298, 27);
            this.CmbEmpresa.TabIndex = 1;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label9.Location = new System.Drawing.Point(368, 80);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(51, 19);
            this.Label9.TabIndex = 106;
            this.Label9.Text = "Dados:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label5.Location = new System.Drawing.Point(19, 21);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 19);
            this.Label5.TabIndex = 89;
            this.Label5.Text = "Empresa:";
            // 
            // CmbNome
            // 
            this.CmbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNome.Enabled = false;
            this.CmbNome.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbNome.FormattingEnabled = true;
            this.CmbNome.Location = new System.Drawing.Point(368, 39);
            this.CmbNome.Name = "CmbNome";
            this.CmbNome.Size = new System.Drawing.Size(263, 27);
            this.CmbNome.TabIndex = 2;
            // 
            // CmbTpChip
            // 
            this.CmbTpChip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTpChip.Enabled = false;
            this.CmbTpChip.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbTpChip.FormattingEnabled = true;
            this.CmbTpChip.Items.AddRange(new object[] {
            "SIM card",
            "eSIM"});
            this.CmbTpChip.Location = new System.Drawing.Point(16, 161);
            this.CmbTpChip.Name = "CmbTpChip";
            this.CmbTpChip.Size = new System.Drawing.Size(111, 27);
            this.CmbTpChip.TabIndex = 7;
            // 
            // CmbSituacao
            // 
            this.CmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSituacao.Enabled = false;
            this.CmbSituacao.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbSituacao.FormattingEnabled = true;
            this.CmbSituacao.Items.AddRange(new object[] {
            "Ativa",
            "Inativa",
            "Bloqueado"});
            this.CmbSituacao.Location = new System.Drawing.Point(520, 99);
            this.CmbSituacao.Name = "CmbSituacao";
            this.CmbSituacao.Size = new System.Drawing.Size(111, 27);
            this.CmbSituacao.TabIndex = 6;
            // 
            // CmbConta
            // 
            this.CmbConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbConta.Enabled = false;
            this.CmbConta.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbConta.FormattingEnabled = true;
            this.CmbConta.Items.AddRange(new object[] {
            "345782240",
            "384758292",
            "424980793",
            "440948419",
            "441021921",
            "446199996",
            "459450038",
            "455646029",
            "433659995"});
            this.CmbConta.Location = new System.Drawing.Point(173, 99);
            this.CmbConta.Name = "CmbConta";
            this.CmbConta.Size = new System.Drawing.Size(141, 27);
            this.CmbConta.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label1.Location = new System.Drawing.Point(530, 139);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 19);
            this.Label1.TabIndex = 110;
            this.Label1.Text = "Valor mensal";
            // 
            // CmbDados
            // 
            this.CmbDados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDados.Enabled = false;
            this.CmbDados.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbDados.FormattingEnabled = true;
            this.CmbDados.Items.AddRange(new object[] {
            "3G",
            "6G",
            "15G",
            "20G",
            "25G",
            "30G",
            "40G",
            "50G",
            "60G",
            "80G",
            "100G"});
            this.CmbDados.Location = new System.Drawing.Point(368, 99);
            this.CmbDados.Name = "CmbDados";
            this.CmbDados.Size = new System.Drawing.Size(100, 27);
            this.CmbDados.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label3.Location = new System.Drawing.Point(19, 141);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 19);
            this.Label3.TabIndex = 88;
            this.Label3.Text = "Tipo de Chip:";
            // 
            // CmbOpera
            // 
            this.CmbOpera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOpera.Enabled = false;
            this.CmbOpera.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbOpera.FormattingEnabled = true;
            this.CmbOpera.Items.AddRange(new object[] {
            "Vivo"});
            this.CmbOpera.Location = new System.Drawing.Point(173, 159);
            this.CmbOpera.Name = "CmbOpera";
            this.CmbOpera.Size = new System.Drawing.Size(116, 27);
            this.CmbOpera.TabIndex = 4;
            // 
            // TxtLinha
            // 
            this.TxtLinha.Enabled = false;
            this.TxtLinha.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtLinha.Location = new System.Drawing.Point(16, 101);
            this.TxtLinha.Mask = "(00)00000-0000";
            this.TxtLinha.Name = "TxtLinha";
            this.TxtLinha.Size = new System.Drawing.Size(111, 26);
            this.TxtLinha.TabIndex = 3;
            // 
            // FrmCadFone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1027, 660);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DgvTelefones);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadFone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Linhas telefonicas";
            this.Load += new System.EventHandler(this.FrmCadFone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTelefones)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.DataGridView DgvTelefones;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtVencimento;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ComboBox CmbPesquisa;
        internal System.Windows.Forms.Button BtnFiltrar;
        internal System.Windows.Forms.TextBox TxtValor;
        internal System.Windows.Forms.ComboBox CmbEmpresa;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox CmbNome;
        internal System.Windows.Forms.ComboBox CmbTpChip;
        internal System.Windows.Forms.ComboBox CmbSituacao;
        internal System.Windows.Forms.ComboBox CmbConta;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox CmbDados;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RadioButton RdbNome;
        internal System.Windows.Forms.RadioButton RdbLinha;
        internal System.Windows.Forms.ComboBox CmbOpera;
        internal System.Windows.Forms.MaskedTextBox TxtLinha;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox TxtPesquisa;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.MaskedTextBox TxtVigPlano;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label13;
    }
}