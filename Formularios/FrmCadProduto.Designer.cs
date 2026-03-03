namespace Inventario.Formularios
{
    partial class FrmCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProduto));
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnAddImagem = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbModelo = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.rdbDescricao = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtModelo.Location = new System.Drawing.Point(20, 96);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(252, 26);
            this.txtModelo.TabIndex = 3;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label9.Location = new System.Drawing.Point(24, 76);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(59, 19);
            this.Label9.TabIndex = 69;
            this.Label9.Text = "Modelo:";
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
            this.BtnExcluir.Location = new System.Drawing.Point(731, 495);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 37);
            this.BtnExcluir.TabIndex = 68;
            this.BtnExcluir.Text = "E&xcluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
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
            this.BtnCancelar.Location = new System.Drawing.Point(538, 495);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(103, 37);
            this.BtnCancelar.TabIndex = 67;
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
            this.BtnSalvar.Location = new System.Drawing.Point(303, 495);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(103, 37);
            this.BtnSalvar.TabIndex = 66;
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
            this.BtnNovo.Location = new System.Drawing.Point(71, 495);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(103, 37);
            this.BtnNovo.TabIndex = 4;
            this.BtnNovo.Text = "&Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.BackgroundColor = System.Drawing.Color.MintCream;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(14, 216);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProdutos.Size = new System.Drawing.Size(871, 259);
            this.DgvProdutos.TabIndex = 64;
            this.DgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellClick_1);
            this.DgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellDoubleClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtDescricao.Location = new System.Drawing.Point(20, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(253, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label4.Location = new System.Drawing.Point(24, 17);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(70, 19);
            this.Label4.TabIndex = 63;
            this.Label4.Text = "Descrição:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtModelo);
            this.GroupBox1.Controls.Add(this.txtMarca);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.btnAddImagem);
            this.GroupBox1.Controls.Add(this.picFoto);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.txtDescricao);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GroupBox1.Location = new System.Drawing.Point(14, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(871, 197);
            this.GroupBox1.TabIndex = 71;
            this.GroupBox1.TabStop = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.txtMarca.Location = new System.Drawing.Point(315, 37);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(209, 26);
            this.txtMarca.TabIndex = 2;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label8.Location = new System.Drawing.Point(319, 17);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(47, 19);
            this.Label8.TabIndex = 51;
            this.Label8.Text = "Marca";
            // 
            // btnAddImagem
            // 
            this.btnAddImagem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImagem.Enabled = false;
            this.btnAddImagem.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnAddImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MintCream;
            this.btnAddImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImagem.Location = new System.Drawing.Point(545, 119);
            this.btnAddImagem.Name = "btnAddImagem";
            this.btnAddImagem.Size = new System.Drawing.Size(20, 20);
            this.btnAddImagem.TabIndex = 50;
            this.btnAddImagem.Text = "+";
            this.btnAddImagem.UseVisualStyleBackColor = false;
            this.btnAddImagem.Click += new System.EventHandler(this.BtnAddImagem_Click);
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.Honeydew;
            this.picFoto.Location = new System.Drawing.Point(567, 19);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(120, 120);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 49;
            this.picFoto.TabStop = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rdbModelo);
            this.GroupBox2.Controls.Add(this.rdbMarca);
            this.GroupBox2.Controls.Add(this.rdbDescricao);
            this.GroupBox2.Controls.Add(this.txtPesquisa);
            this.GroupBox2.Location = new System.Drawing.Point(693, 13);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(172, 127);
            this.GroupBox2.TabIndex = 52;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Pesquisar";
            // 
            // rdbModelo
            // 
            this.rdbModelo.AutoSize = true;
            this.rdbModelo.Location = new System.Drawing.Point(10, 70);
            this.rdbModelo.Name = "rdbModelo";
            this.rdbModelo.Size = new System.Drawing.Size(74, 23);
            this.rdbModelo.TabIndex = 74;
            this.rdbModelo.TabStop = true;
            this.rdbModelo.Text = "Modelo";
            this.rdbModelo.UseVisualStyleBackColor = true;
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Location = new System.Drawing.Point(10, 43);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(65, 23);
            this.rdbMarca.TabIndex = 73;
            this.rdbMarca.TabStop = true;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            // 
            // rdbDescricao
            // 
            this.rdbDescricao.AutoSize = true;
            this.rdbDescricao.Location = new System.Drawing.Point(10, 17);
            this.rdbDescricao.Name = "rdbDescricao";
            this.rdbDescricao.Size = new System.Drawing.Size(85, 23);
            this.rdbDescricao.TabIndex = 72;
            this.rdbDescricao.TabStop = true;
            this.rdbDescricao.Text = "Descrição";
            this.rdbDescricao.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Enabled = false;
            this.txtPesquisa.Location = new System.Drawing.Point(10, 96);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(145, 26);
            this.txtPesquisa.TabIndex = 71;
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 554);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox txtModelo;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.DataGridView DgvProdutos;
        internal System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtMarca;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnAddImagem;
        internal System.Windows.Forms.PictureBox picFoto;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton rdbModelo;
        private System.Windows.Forms.RadioButton rdbMarca;
        private System.Windows.Forms.RadioButton rdbDescricao;
        internal System.Windows.Forms.TextBox txtPesquisa;
    }
}