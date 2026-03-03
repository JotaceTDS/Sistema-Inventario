namespace Inventario.Formularios
{
    partial class FrmCadDpto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadDpto));
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvDpto = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDpto)).BeginInit();
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
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnExcluir.Location = new System.Drawing.Point(356, 321);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(103, 37);
            this.BtnExcluir.TabIndex = 75;
            this.BtnExcluir.Text = "Excluir";
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
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCancelar.Location = new System.Drawing.Point(240, 321);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(103, 37);
            this.BtnCancelar.TabIndex = 74;
            this.BtnCancelar.Text = "Cancelar";
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
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSalvar.Location = new System.Drawing.Point(124, 321);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(103, 37);
            this.BtnSalvar.TabIndex = 73;
            this.BtnSalvar.Text = "Salvar";
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
            this.BtnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNovo.Location = new System.Drawing.Point(8, 321);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(89, 37);
            this.BtnNovo.TabIndex = 72;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.TxtDescricao);
            this.GroupBox1.Controls.Add(this.TxtCodigo);
            this.GroupBox1.Location = new System.Drawing.Point(8, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(447, 123);
            this.GroupBox1.TabIndex = 76;
            this.GroupBox1.TabStop = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label11.Location = new System.Drawing.Point(23, 12);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(56, 19);
            this.Label11.TabIndex = 63;
            this.Label11.Text = "Codigo:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label2.Location = new System.Drawing.Point(23, 70);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(101, 19);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Departamento:";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Enabled = false;
            this.TxtDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricao.Location = new System.Drawing.Point(19, 93);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(244, 22);
            this.TxtDescricao.TabIndex = 35;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.TxtCodigo.Enabled = false;
            this.TxtCodigo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.TxtCodigo.Location = new System.Drawing.Point(19, 35);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(94, 26);
            this.TxtCodigo.TabIndex = 52;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.DgvDpto);
            this.GroupBox2.Location = new System.Drawing.Point(8, 136);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(447, 167);
            this.GroupBox2.TabIndex = 77;
            this.GroupBox2.TabStop = false;
            // 
            // DgvDpto
            // 
            this.DgvDpto.AllowUserToAddRows = false;
            this.DgvDpto.AllowUserToDeleteRows = false;
            this.DgvDpto.BackgroundColor = System.Drawing.Color.MintCream;
            this.DgvDpto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDpto.Location = new System.Drawing.Point(15, 16);
            this.DgvDpto.Name = "DgvDpto";
            this.DgvDpto.ReadOnly = true;
            this.DgvDpto.RowHeadersWidth = 62;
            this.DgvDpto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDpto.Size = new System.Drawing.Size(418, 145);
            this.DgvDpto.TabIndex = 53;
            this.DgvDpto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDpto_CellDoubleClick);
            // 
            // FrmCadDpto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 377);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadDpto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Departamento";
            this.Load += new System.EventHandler(this.FrmCadDpto_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDpto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtDescricao;
        internal System.Windows.Forms.TextBox TxtCodigo;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView DgvDpto;
    }
}