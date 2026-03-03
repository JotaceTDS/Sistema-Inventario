namespace Inventario.Formularios
{
    partial class FrmCadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFornecedor));
            this.TxtIe = new System.Windows.Forms.MaskedTextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.rdbCnpj = new System.Windows.Forms.RadioButton();
            this.rdbRazao = new System.Windows.Forms.RadioButton();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.DgvFornecedor = new System.Windows.Forms.DataGridView();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCep = new System.Windows.Forms.MaskedTextBox();
            this.TxtContato = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtUf = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.TxtFantasia = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtRazao = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedor)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIe
            // 
            this.TxtIe.Enabled = false;
            this.TxtIe.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtIe.Location = new System.Drawing.Point(179, 44);
            this.TxtIe.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIe.Mask = "000,000,000,000";
            this.TxtIe.Name = "TxtIe";
            this.TxtIe.Size = new System.Drawing.Size(146, 26);
            this.TxtIe.TabIndex = 2;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label7.Location = new System.Drawing.Point(183, 24);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(120, 19);
            this.Label7.TabIndex = 96;
            this.Label7.Text = "Inscrição Estadual:";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPesquisa.Location = new System.Drawing.Point(25, 86);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(141, 22);
            this.TxtPesquisa.TabIndex = 95;
            this.TxtPesquisa.TextChanged += new System.EventHandler(this.TxtPesquisa_TextChanged);
            // 
            // rdbCnpj
            // 
            this.rdbCnpj.AutoSize = true;
            this.rdbCnpj.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCnpj.Location = new System.Drawing.Point(27, 51);
            this.rdbCnpj.Name = "rdbCnpj";
            this.rdbCnpj.Size = new System.Drawing.Size(58, 20);
            this.rdbCnpj.TabIndex = 97;
            this.rdbCnpj.Text = "CNPJ";
            this.rdbCnpj.UseVisualStyleBackColor = true;
            // 
            // rdbRazao
            // 
            this.rdbRazao.AutoSize = true;
            this.rdbRazao.Checked = true;
            this.rdbRazao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRazao.Location = new System.Drawing.Point(25, 20);
            this.rdbRazao.Name = "rdbRazao";
            this.rdbRazao.Size = new System.Drawing.Size(102, 20);
            this.rdbRazao.TabIndex = 96;
            this.rdbRazao.TabStop = true;
            this.rdbRazao.Text = "Razão Social";
            this.rdbRazao.UseVisualStyleBackColor = true;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Enabled = false;
            this.TxtEndereco.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtEndereco.Location = new System.Drawing.Point(179, 114);
            this.TxtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(240, 26);
            this.TxtEndereco.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TxtPesquisa);
            this.GroupBox1.Controls.Add(this.rdbCnpj);
            this.GroupBox1.Controls.Add(this.rdbRazao);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GroupBox1.Location = new System.Drawing.Point(892, 14);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(184, 126);
            this.GroupBox1.TabIndex = 94;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Buscar:";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Enabled = false;
            this.TxtTelefone.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtTelefone.Location = new System.Drawing.Point(320, 185);
            this.TxtTelefone.Mask = "(00)00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(198, 26);
            this.TxtTelefone.TabIndex = 11;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtEmail.Location = new System.Drawing.Point(13, 185);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(275, 26);
            this.TxtEmail.TabIndex = 10;
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
            this.BtnNovo.Location = new System.Drawing.Point(52, 533);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(103, 37);
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
            this.BtnExcluir.Location = new System.Drawing.Point(970, 533);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 37);
            this.BtnExcluir.TabIndex = 16;
            this.BtnExcluir.Text = "&Excluir";
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
            this.BtnSalvar.Location = new System.Drawing.Point(355, 533);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(103, 37);
            this.BtnSalvar.TabIndex = 14;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // DgvFornecedor
            // 
            this.DgvFornecedor.AllowUserToAddRows = false;
            this.DgvFornecedor.AllowUserToDeleteRows = false;
            this.DgvFornecedor.BackgroundColor = System.Drawing.Color.MintCream;
            this.DgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFornecedor.Location = new System.Drawing.Point(10, 242);
            this.DgvFornecedor.Name = "DgvFornecedor";
            this.DgvFornecedor.ReadOnly = true;
            this.DgvFornecedor.RowHeadersWidth = 62;
            this.DgvFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFornecedor.Size = new System.Drawing.Size(1093, 267);
            this.DgvFornecedor.TabIndex = 91;
            this.DgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFornecedor_CellClick);
            this.DgvFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFornecedor_CellDoubleClick);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TxtCep);
            this.GroupBox2.Controls.Add(this.TxtContato);
            this.GroupBox2.Controls.Add(this.label12);
            this.GroupBox2.Controls.Add(this.TxtUf);
            this.GroupBox2.Controls.Add(this.label11);
            this.GroupBox2.Controls.Add(this.TxtCidade);
            this.GroupBox2.Controls.Add(this.label10);
            this.GroupBox2.Controls.Add(this.TxtBairro);
            this.GroupBox2.Controls.Add(this.label9);
            this.GroupBox2.Controls.Add(this.label8);
            this.GroupBox2.Controls.Add(this.TxtEndereco);
            this.GroupBox2.Controls.Add(this.TxtIe);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.GroupBox1);
            this.GroupBox2.Controls.Add(this.TxtTelefone);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.TxtEmail);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.TxtCnpj);
            this.GroupBox2.Controls.Add(this.TxtFantasia);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.TxtRazao);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(10, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(1093, 228);
            this.GroupBox2.TabIndex = 92;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Dados Fornecedor:";
            // 
            // TxtCep
            // 
            this.TxtCep.Enabled = false;
            this.TxtCep.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtCep.Location = new System.Drawing.Point(13, 114);
            this.TxtCep.Mask = "00000\\-000";
            this.TxtCep.Name = "TxtCep";
            this.TxtCep.Size = new System.Drawing.Size(154, 26);
            this.TxtCep.TabIndex = 5;
            // 
            // TxtContato
            // 
            this.TxtContato.Enabled = false;
            this.TxtContato.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtContato.Location = new System.Drawing.Point(606, 185);
            this.TxtContato.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContato.Name = "TxtContato";
            this.TxtContato.Size = new System.Drawing.Size(161, 26);
            this.TxtContato.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label12.Location = new System.Drawing.Point(610, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 106;
            this.label12.Text = "Contato:";
            // 
            // TxtUf
            // 
            this.TxtUf.Enabled = false;
            this.TxtUf.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtUf.Location = new System.Drawing.Point(788, 114);
            this.TxtUf.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUf.Name = "TxtUf";
            this.TxtUf.Size = new System.Drawing.Size(87, 26);
            this.TxtUf.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label11.Location = new System.Drawing.Point(791, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 19);
            this.label11.TabIndex = 104;
            this.label11.Text = "UF:";
            // 
            // TxtCidade
            // 
            this.TxtCidade.Enabled = false;
            this.TxtCidade.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtCidade.Location = new System.Drawing.Point(606, 114);
            this.TxtCidade.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(161, 26);
            this.TxtCidade.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label10.Location = new System.Drawing.Point(610, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 102;
            this.label10.Text = "Cidade:";
            // 
            // TxtBairro
            // 
            this.TxtBairro.Enabled = false;
            this.TxtBairro.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtBairro.Location = new System.Drawing.Point(435, 114);
            this.TxtBairro.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(153, 26);
            this.TxtBairro.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label9.Location = new System.Drawing.Point(439, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 100;
            this.label9.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label8.Location = new System.Drawing.Point(18, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 19);
            this.label8.TabIndex = 98;
            this.label8.Text = "CEP:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label6.Location = new System.Drawing.Point(322, 168);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(62, 19);
            this.Label6.TabIndex = 91;
            this.Label6.Text = "Telefone:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label5.Location = new System.Drawing.Point(181, 97);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 19);
            this.Label5.TabIndex = 89;
            this.Label5.Text = "Endereço:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label1.Location = new System.Drawing.Point(18, 165);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 19);
            this.Label1.TabIndex = 87;
            this.Label1.Text = "E-mail:";
            // 
            // TxtCnpj
            // 
            this.TxtCnpj.Enabled = false;
            this.TxtCnpj.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtCnpj.Location = new System.Drawing.Point(13, 44);
            this.TxtCnpj.Mask = "00,000,000/0000-00";
            this.TxtCnpj.Name = "TxtCnpj";
            this.TxtCnpj.Size = new System.Drawing.Size(154, 26);
            this.TxtCnpj.TabIndex = 1;
            // 
            // TxtFantasia
            // 
            this.TxtFantasia.Enabled = false;
            this.TxtFantasia.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtFantasia.Location = new System.Drawing.Point(606, 44);
            this.TxtFantasia.Name = "TxtFantasia";
            this.TxtFantasia.Size = new System.Drawing.Size(275, 26);
            this.TxtFantasia.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label3.Location = new System.Drawing.Point(611, 25);
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
            this.Label4.Location = new System.Drawing.Point(17, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(43, 19);
            this.Label4.TabIndex = 82;
            this.Label4.Text = "CNPJ:";
            // 
            // TxtRazao
            // 
            this.TxtRazao.Enabled = false;
            this.TxtRazao.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtRazao.Location = new System.Drawing.Point(348, 44);
            this.TxtRazao.Name = "TxtRazao";
            this.TxtRazao.Size = new System.Drawing.Size(240, 26);
            this.TxtRazao.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label2.Location = new System.Drawing.Point(353, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(86, 19);
            this.Label2.TabIndex = 81;
            this.Label2.Text = "Razão Social:";
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
            this.BtnCancelar.Location = new System.Drawing.Point(671, 533);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(103, 37);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1115, 597);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DgvFornecedor);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.BtnCancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.FrmCadFornecedor_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFornecedor)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.MaskedTextBox TxtIe;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.MaskedTextBox TxtPesquisa;
        internal System.Windows.Forms.RadioButton rdbCnpj;
        internal System.Windows.Forms.RadioButton rdbRazao;
        internal System.Windows.Forms.TextBox TxtEndereco;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.MaskedTextBox TxtTelefone;
        internal System.Windows.Forms.TextBox TxtEmail;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.DataGridView DgvFornecedor;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.MaskedTextBox TxtCnpj;
        internal System.Windows.Forms.TextBox TxtFantasia;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TxtRazao;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox TxtBairro;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox TxtUf;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox TxtCidade;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox TxtContato;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.MaskedTextBox TxtCep;
    }
}