namespace Inventario.Formularios
{
    partial class FrmCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargo));
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.DgvCargo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCargo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnExcluir.Location = new System.Drawing.Point(383, 345);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(77, 37);
            this.BtnExcluir.TabIndex = 80;
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
            this.BtnCancelar.Location = new System.Drawing.Point(256, 345);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(77, 37);
            this.BtnCancelar.TabIndex = 79;
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
            this.BtnSalvar.Location = new System.Drawing.Point(138, 345);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(77, 37);
            this.BtnSalvar.TabIndex = 78;
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
            this.BtnNovo.Location = new System.Drawing.Point(21, 345);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(77, 37);
            this.BtnNovo.TabIndex = 76;
            this.BtnNovo.Text = "&Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DgvCargo
            // 
            this.DgvCargo.AllowUserToAddRows = false;
            this.DgvCargo.AllowUserToDeleteRows = false;
            this.DgvCargo.BackgroundColor = System.Drawing.Color.MintCream;
            this.DgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCargo.Location = new System.Drawing.Point(20, 80);
            this.DgvCargo.Name = "DgvCargo";
            this.DgvCargo.ReadOnly = true;
            this.DgvCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCargo.Size = new System.Drawing.Size(402, 218);
            this.DgvCargo.TabIndex = 77;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtNome);
            this.groupBox3.Controls.Add(this.Label9);
            this.groupBox3.Controls.Add(this.TxtCodigo);
            this.groupBox3.Controls.Add(this.Label4);
            this.groupBox3.Controls.Add(this.DgvCargo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.groupBox3.Location = new System.Drawing.Point(21, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 314);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            // 
            // TxtNome
            // 
            this.TxtNome.Enabled = false;
            this.TxtNome.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtNome.Location = new System.Drawing.Point(131, 37);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(291, 26);
            this.TxtNome.TabIndex = 3;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label9.Location = new System.Drawing.Point(135, 17);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(56, 19);
            this.Label9.TabIndex = 69;
            this.Label9.Text = "Função:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtCodigo.Location = new System.Drawing.Point(20, 37);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(85, 26);
            this.TxtCodigo.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label4.Location = new System.Drawing.Point(24, 17);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 19);
            this.Label4.TabIndex = 63;
            this.Label4.Text = "Codigo:";
            // 
            // FrmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 400);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cargos";
            this.Load += new System.EventHandler(this.FrmCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCargo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.DataGridView DgvCargo;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox TxtNome;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TxtCodigo;
        internal System.Windows.Forms.Label Label4;
    }
}