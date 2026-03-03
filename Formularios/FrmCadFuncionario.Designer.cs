namespace Inventario.Formularios
{
    partial class FrmCadFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFuncionario));
            this.CmbCargo = new System.Windows.Forms.ComboBox();
            this.CmbDpto = new System.Windows.Forms.ComboBox();
            this.CmbEmpresa = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.DgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.CmbPesquisa = new System.Windows.Forms.ComboBox();
            this.CmbLocal = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbNome = new System.Windows.Forms.RadioButton();
            this.RdbCpf = new System.Windows.Forms.RadioButton();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbCargo
            // 
            this.CmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCargo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbCargo.FormattingEnabled = true;
            this.CmbCargo.Location = new System.Drawing.Point(127, 166);
            this.CmbCargo.Name = "CmbCargo";
            this.CmbCargo.Size = new System.Drawing.Size(173, 27);
            this.CmbCargo.TabIndex = 8;
            // 
            // CmbDpto
            // 
            this.CmbDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDpto.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbDpto.FormattingEnabled = true;
            this.CmbDpto.Items.AddRange(new object[] {
            "Administrativo",
            "Comercial",
            "Contabilidade",
            "Diretoria",
            "DP",
            "Financeiro",
            "Geral",
            "Imprensa",
            "Investimento",
            "Juridico",
            "Marketing",
            "Pedagogico ",
            "Presidencia",
            "Recepção",
            "RH",
            "TI"});
            this.CmbDpto.Location = new System.Drawing.Point(536, 55);
            this.CmbDpto.Name = "CmbDpto";
            this.CmbDpto.Size = new System.Drawing.Size(112, 27);
            this.CmbDpto.TabIndex = 3;
            // 
            // CmbEmpresa
            // 
            this.CmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmpresa.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbEmpresa.FormattingEnabled = true;
            this.CmbEmpresa.Location = new System.Drawing.Point(308, 56);
            this.CmbEmpresa.Name = "CmbEmpresa";
            this.CmbEmpresa.Size = new System.Drawing.Size(192, 27);
            this.CmbEmpresa.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label10.Location = new System.Drawing.Point(346, 146);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(76, 19);
            this.Label10.TabIndex = 57;
            this.Label10.Text = "Localidade:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label9.Location = new System.Drawing.Point(130, 146);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(49, 19);
            this.Label9.TabIndex = 56;
            this.Label9.Text = "Cargo:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(30, 161);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(68, 16);
            this.Label8.TabIndex = 55;
            this.Label8.Text = "Matricula.:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtEmail.Location = new System.Drawing.Point(27, 117);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(244, 26);
            this.TxtEmail.TabIndex = 4;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(311, 36);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 16);
            this.Label6.TabIndex = 54;
            this.Label6.Text = "Empresa";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnExcluir.Location = new System.Drawing.Point(779, 505);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 37);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(536, 505);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(103, 37);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnSalvar.Location = new System.Drawing.Point(292, 505);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(103, 37);
            this.BtnSalvar.TabIndex = 11;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.Enabled = false;
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream;
            this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnNovo.Location = new System.Drawing.Point(24, 505);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(103, 37);
            this.BtnNovo.TabIndex = 10;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DgvFuncionarios
            // 
            this.DgvFuncionarios.AllowUserToAddRows = false;
            this.DgvFuncionarios.AllowUserToDeleteRows = false;
            this.DgvFuncionarios.BackgroundColor = System.Drawing.Color.MintCream;
            this.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionarios.Location = new System.Drawing.Point(12, 252);
            this.DgvFuncionarios.Name = "DgvFuncionarios";
            this.DgvFuncionarios.ReadOnly = true;
            this.DgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionarios.Size = new System.Drawing.Size(884, 224);
            this.DgvFuncionarios.TabIndex = 49;
            this.DgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFuncionarios_CellClick);
            this.DgvFuncionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFuncionarios_CellDoubleClick);
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtTelefone.Location = new System.Drawing.Point(298, 105);
            this.TxtTelefone.Mask = "(00)00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(149, 26);
            this.TxtTelefone.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(312, 96);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 16);
            this.Label5.TabIndex = 48;
            this.Label5.Text = "Telefone:";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtMatricula.Location = new System.Drawing.Point(27, 180);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(71, 26);
            this.TxtMatricula.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(30, 97);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(44, 16);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "E-mail";
            // 
            // TxtCpf
            // 
            this.TxtCpf.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtCpf.Location = new System.Drawing.Point(481, 105);
            this.TxtCpf.Mask = "000,000,000-00";
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(112, 26);
            this.TxtCpf.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(497, 97);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 16);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "CPF:";
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtNome.Location = new System.Drawing.Point(27, 57);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(244, 26);
            this.TxtNome.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(30, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(45, 16);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Nome:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.CmbCargo);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.CmbLocal);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.GroupBox1);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.TxtTelefone);
            this.GroupBox2.Controls.Add(this.TxtCpf);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(11, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(885, 228);
            this.GroupBox2.TabIndex = 59;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Dados";
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.BtnFiltrar);
            this.GroupBox3.Controls.Add(this.CmbPesquisa);
            this.GroupBox3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GroupBox3.Location = new System.Drawing.Point(692, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(179, 101);
            this.GroupBox3.TabIndex = 37;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Filtar empresa:";
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrar.Location = new System.Drawing.Point(54, 61);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 111;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // CmbPesquisa
            // 
            this.CmbPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPesquisa.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbPesquisa.FormattingEnabled = true;
            this.CmbPesquisa.Location = new System.Drawing.Point(10, 27);
            this.CmbPesquisa.Name = "CmbPesquisa";
            this.CmbPesquisa.Size = new System.Drawing.Size(159, 27);
            this.CmbPesquisa.TabIndex = 112;
            // 
            // CmbLocal
            // 
            this.CmbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLocal.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.CmbLocal.FormattingEnabled = true;
            this.CmbLocal.Location = new System.Drawing.Point(342, 166);
            this.CmbLocal.Name = "CmbLocal";
            this.CmbLocal.Size = new System.Drawing.Size(112, 27);
            this.CmbLocal.TabIndex = 9;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.RdbNome);
            this.GroupBox1.Controls.Add(this.RdbCpf);
            this.GroupBox1.Controls.Add(this.TxtPesquisa);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GroupBox1.Location = new System.Drawing.Point(692, 113);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(179, 102);
            this.GroupBox1.TabIndex = 36;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Buscar";
            // 
            // RdbNome
            // 
            this.RdbNome.AutoSize = true;
            this.RdbNome.BackColor = System.Drawing.Color.Transparent;
            this.RdbNome.Checked = true;
            this.RdbNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbNome.Location = new System.Drawing.Point(10, 19);
            this.RdbNome.Name = "RdbNome";
            this.RdbNome.Size = new System.Drawing.Size(63, 20);
            this.RdbNome.TabIndex = 5;
            this.RdbNome.TabStop = true;
            this.RdbNome.Text = "Nome:";
            this.RdbNome.UseVisualStyleBackColor = false;
            // 
            // RdbCpf
            // 
            this.RdbCpf.AutoSize = true;
            this.RdbCpf.BackColor = System.Drawing.Color.Transparent;
            this.RdbCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCpf.Location = new System.Drawing.Point(11, 41);
            this.RdbCpf.Name = "RdbCpf";
            this.RdbCpf.Size = new System.Drawing.Size(55, 20);
            this.RdbCpf.TabIndex = 6;
            this.RdbCpf.Text = "CPF:";
            this.RdbCpf.UseVisualStyleBackColor = false;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtPesquisa.Location = new System.Drawing.Point(10, 65);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(160, 26);
            this.TxtPesquisa.TabIndex = 5;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label7.Location = new System.Drawing.Point(530, 23);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(98, 19);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Departamento";
            // 
            // FrmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 562);
            this.Controls.Add(this.CmbDpto);
            this.Controls.Add(this.CmbEmpresa);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.DgvFuncionarios);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionarios";
            this.Load += new System.EventHandler(this.FrmCadFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox CmbCargo;
        internal System.Windows.Forms.ComboBox CmbDpto;
        internal System.Windows.Forms.ComboBox CmbEmpresa;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox TxtEmail;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.DataGridView DgvFuncionarios;
        internal System.Windows.Forms.MaskedTextBox TxtTelefone;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TxtMatricula;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.MaskedTextBox TxtCpf;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtNome;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button BtnFiltrar;
        internal System.Windows.Forms.ComboBox CmbPesquisa;
        internal System.Windows.Forms.ComboBox CmbLocal;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RdbNome;
        internal System.Windows.Forms.RadioButton RdbCpf;
        internal System.Windows.Forms.TextBox TxtPesquisa;
    }
}