namespace Inventario.Formularios
{
    partial class FrmCadEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadEmpresa));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.DgvEmpresas = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCpf = new System.Windows.Forms.RadioButton();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresas)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnCancelar.Location = new System.Drawing.Point(959, 661);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(137, 46);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnNovo.Location = new System.Drawing.Point(153, 661);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(137, 46);
            this.BtnNovo.TabIndex = 13;
            this.BtnNovo.Text = "&Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
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
            this.BtnExcluir.Location = new System.Drawing.Point(1345, 661);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(137, 46);
            this.BtnExcluir.TabIndex = 16;
            this.BtnExcluir.Text = "&E&xcluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
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
            this.BtnSalvar.Location = new System.Drawing.Point(509, 661);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(137, 46);
            this.BtnSalvar.TabIndex = 14;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // DgvEmpresas
            // 
            this.DgvEmpresas.AllowUserToAddRows = false;
            this.DgvEmpresas.AllowUserToDeleteRows = false;
            this.DgvEmpresas.BackgroundColor = System.Drawing.Color.MintCream;
            this.DgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpresas.Location = new System.Drawing.Point(15, 302);
            this.DgvEmpresas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvEmpresas.Name = "DgvEmpresas";
            this.DgvEmpresas.ReadOnly = true;
            this.DgvEmpresas.RowHeadersWidth = 62;
            this.DgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpresas.Size = new System.Drawing.Size(1592, 352);
            this.DgvEmpresas.TabIndex = 85;
            this.DgvEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresas_CellClick);
            this.DgvEmpresas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresas_CellDoubleClick);
            this.DgvEmpresas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvEmpresas_CellFormatting);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(-68, 9);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(73, 22);
            this.txtCodigo.TabIndex = 84;
            this.txtCodigo.Visible = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtCep);
            this.GroupBox2.Controls.Add(this.txtContato);
            this.GroupBox2.Controls.Add(this.label12);
            this.GroupBox2.Controls.Add(this.txtUf);
            this.GroupBox2.Controls.Add(this.label11);
            this.GroupBox2.Controls.Add(this.txtCidade);
            this.GroupBox2.Controls.Add(this.label10);
            this.GroupBox2.Controls.Add(this.txtBairro);
            this.GroupBox2.Controls.Add(this.label9);
            this.GroupBox2.Controls.Add(this.label8);
            this.GroupBox2.Controls.Add(this.txtEndereco);
            this.GroupBox2.Controls.Add(this.txtTelefone);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.label7);
            this.GroupBox2.Controls.Add(this.txtEmail);
            this.GroupBox2.Controls.Add(this.label13);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Controls.Add(this.txtIe);
            this.GroupBox2.Controls.Add(this.txtCnpj);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.txtFantasia);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtRazao);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.GroupBox1);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(13, 5);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(1593, 281);
            this.GroupBox2.TabIndex = 86;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Dados";
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtCep.Location = new System.Drawing.Point(20, 140);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCep.Mask = "00000\\-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(204, 26);
            this.txtCep.TabIndex = 5;
            this.txtCep.Leave += new System.EventHandler(this.TxtCep_Leave);
            // 
            // txtContato
            // 
            this.txtContato.Enabled = false;
            this.txtContato.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtContato.Location = new System.Drawing.Point(811, 228);
            this.txtContato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(213, 26);
            this.txtContato.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label12.Location = new System.Drawing.Point(816, 203);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 130;
            this.label12.Text = "Contato:";
            // 
            // txtUf
            // 
            this.txtUf.Enabled = false;
            this.txtUf.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtUf.Location = new System.Drawing.Point(1053, 140);
            this.txtUf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(115, 26);
            this.txtUf.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label11.Location = new System.Drawing.Point(1057, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 19);
            this.label11.TabIndex = 129;
            this.label11.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtCidade.Location = new System.Drawing.Point(811, 140);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(213, 26);
            this.txtCidade.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label10.Location = new System.Drawing.Point(816, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 128;
            this.label10.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtBairro.Location = new System.Drawing.Point(583, 140);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(203, 26);
            this.txtBairro.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label9.Location = new System.Drawing.Point(588, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 127;
            this.label9.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label8.Location = new System.Drawing.Point(27, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 126;
            this.label8.Text = "CEP:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtEndereco.Location = new System.Drawing.Point(241, 140);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(319, 26);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtTelefone.Location = new System.Drawing.Point(429, 228);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(263, 26);
            this.txtTelefone.TabIndex = 11;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label6.Location = new System.Drawing.Point(432, 207);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(62, 19);
            this.Label6.TabIndex = 125;
            this.Label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label7.Location = new System.Drawing.Point(244, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 124;
            this.label7.Text = "Endereço:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtEmail.Location = new System.Drawing.Point(20, 228);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(365, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label13.Location = new System.Drawing.Point(27, 203);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 19);
            this.label13.TabIndex = 123;
            this.label13.Text = "E-mail:";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(83, 26);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(15, 14);
            this.Label1.TabIndex = 114;
            this.Label1.Text = "*";
            // 
            // Label18
            // 
            this.Label18.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label18.ForeColor = System.Drawing.Color.Red;
            this.Label18.Location = new System.Drawing.Point(632, 27);
            this.Label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(15, 14);
            this.Label18.TabIndex = 114;
            this.Label18.Text = "*";
            // 
            // txtIe
            // 
            this.txtIe.Enabled = false;
            this.txtIe.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtIe.Location = new System.Drawing.Point(269, 49);
            this.txtIe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIe.Mask = "000,000,000,000";
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(221, 26);
            this.txtIe.TabIndex = 2;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Enabled = false;
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtCnpj.Location = new System.Drawing.Point(23, 49);
            this.txtCnpj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(221, 26);
            this.txtCnpj.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label5.Location = new System.Drawing.Point(273, 27);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(120, 19);
            this.Label5.TabIndex = 84;
            this.Label5.Text = "Inscrição Estadual:";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Enabled = false;
            this.txtFantasia.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtFantasia.Location = new System.Drawing.Point(852, 49);
            this.txtFantasia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(312, 26);
            this.txtFantasia.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label3.Location = new System.Drawing.Point(856, 26);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(103, 19);
            this.Label3.TabIndex = 83;
            this.Label3.Text = "Nome Fantasia:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label4.Location = new System.Drawing.Point(27, 26);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 19);
            this.Label4.TabIndex = 82;
            this.Label4.Text = "CNPJ:";
            // 
            // txtRazao
            // 
            this.txtRazao.Enabled = false;
            this.txtRazao.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtRazao.Location = new System.Drawing.Point(513, 49);
            this.txtRazao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(312, 26);
            this.txtRazao.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label2.Location = new System.Drawing.Point(517, 27);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 19);
            this.Label2.TabIndex = 81;
            this.Label2.Text = "Razão Social:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rdbNome);
            this.GroupBox1.Controls.Add(this.rdbCpf);
            this.GroupBox1.Controls.Add(this.TxtPesquisa);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GroupBox1.Location = new System.Drawing.Point(1356, 26);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(207, 181);
            this.GroupBox1.TabIndex = 87;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Buscar";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.BackColor = System.Drawing.Color.Transparent;
            this.rdbNome.Checked = true;
            this.rdbNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNome.Location = new System.Drawing.Point(21, 27);
            this.rdbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(63, 20);
            this.rdbNome.TabIndex = 72;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome:";
            this.rdbNome.UseVisualStyleBackColor = false;
            // 
            // rdbCpf
            // 
            this.rdbCpf.AutoSize = true;
            this.rdbCpf.BackColor = System.Drawing.Color.Transparent;
            this.rdbCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCpf.Location = new System.Drawing.Point(25, 73);
            this.rdbCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCpf.Name = "rdbCpf";
            this.rdbCpf.Size = new System.Drawing.Size(62, 20);
            this.rdbCpf.TabIndex = 74;
            this.rdbCpf.Text = "CNPJ:";
            this.rdbCpf.UseVisualStyleBackColor = false;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(13, 127);
            this.TxtPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(179, 26);
            this.TxtPesquisa.TabIndex = 73;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // FrmCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1623, 736);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DgvEmpresas);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.GroupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de empresas";
            this.Load += new System.EventHandler(this.FrmCadEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresas)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.DataGridView DgvEmpresas;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.MaskedTextBox txtIe;
        internal System.Windows.Forms.MaskedTextBox txtCnpj;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtFantasia;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtRazao;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rdbNome;
        internal System.Windows.Forms.RadioButton rdbCpf;
        internal System.Windows.Forms.TextBox TxtPesquisa;
        internal System.Windows.Forms.MaskedTextBox txtCep;
        internal System.Windows.Forms.TextBox txtContato;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtUf;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtCidade;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtBairro;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtEndereco;
        internal System.Windows.Forms.MaskedTextBox txtTelefone;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label label13;
    }
}