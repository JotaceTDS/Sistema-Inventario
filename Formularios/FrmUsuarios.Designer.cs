namespace Inventario.Formularios
{
    partial class FrmCadUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUsers));
            this.BtnNovo = new System.Windows.Forms.Button();
            this.CmbAcesso = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.ChkEmpresa7 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkEmpresa8 = new System.Windows.Forms.CheckBox();
            this.ChkTodos = new System.Windows.Forms.CheckBox();
            this.ChkEmpresa1 = new System.Windows.Forms.CheckBox();
            this.ChkEmpresa3 = new System.Windows.Forms.CheckBox();
            this.ChkEmpresa4 = new System.Windows.Forms.CheckBox();
            this.ChkEmpresa6 = new System.Windows.Forms.CheckBox();
            this.ChkEmpresa5 = new System.Windows.Forms.CheckBox();
            this.ChkEmpresa2 = new System.Windows.Forms.CheckBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.GpDados = new System.Windows.Forms.GroupBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbNome = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.GpDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnNovo.Location = new System.Drawing.Point(54, 484);
            this.BtnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(87, 35);
            this.BtnNovo.TabIndex = 4;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // CmbAcesso
            // 
            this.CmbAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAcesso.Enabled = false;
            this.CmbAcesso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAcesso.FormattingEnabled = true;
            this.CmbAcesso.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.CmbAcesso.Location = new System.Drawing.Point(536, 94);
            this.CmbAcesso.Margin = new System.Windows.Forms.Padding(4);
            this.CmbAcesso.Name = "CmbAcesso";
            this.CmbAcesso.Size = new System.Drawing.Size(225, 27);
            this.CmbAcesso.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label3.Location = new System.Drawing.Point(539, 70);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 19);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Acesso:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Enabled = false;
            this.TxtSenha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(290, 94);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(224, 27);
            this.TxtSenha.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(21, 94);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(245, 27);
            this.TxtUsuario.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label2.Location = new System.Drawing.Point(293, 70);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 19);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Senha:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Label1.Location = new System.Drawing.Point(25, 70);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 19);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Usuario:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnSalvar.Location = new System.Drawing.Point(240, 484);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(86, 35);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnExcluir.Location = new System.Drawing.Point(641, 484);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(87, 35);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "&Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // ChkEmpresa7
            // 
            this.ChkEmpresa7.AutoSize = true;
            this.ChkEmpresa7.Enabled = false;
            this.ChkEmpresa7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkEmpresa7.Location = new System.Drawing.Point(544, 28);
            this.ChkEmpresa7.Name = "ChkEmpresa7";
            this.ChkEmpresa7.Size = new System.Drawing.Size(186, 23);
            this.ChkEmpresa7.TabIndex = 29;
            this.ChkEmpresa7.Text = "EA Entretenimento Matriz";
            this.ChkEmpresa7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkEmpresa8);
            this.groupBox1.Controls.Add(this.ChkTodos);
            this.groupBox1.Controls.Add(this.ChkEmpresa1);
            this.groupBox1.Controls.Add(this.ChkEmpresa7);
            this.groupBox1.Controls.Add(this.ChkEmpresa3);
            this.groupBox1.Controls.Add(this.ChkEmpresa4);
            this.groupBox1.Controls.Add(this.ChkEmpresa6);
            this.groupBox1.Controls.Add(this.ChkEmpresa5);
            this.groupBox1.Controls.Add(this.ChkEmpresa2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(18, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 123);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresas";
            // 
            // ChkEmpresa8
            // 
            this.ChkEmpresa8.AutoSize = true;
            this.ChkEmpresa8.Enabled = false;
            this.ChkEmpresa8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkEmpresa8.Location = new System.Drawing.Point(544, 64);
            this.ChkEmpresa8.Name = "ChkEmpresa8";
            this.ChkEmpresa8.Size = new System.Drawing.Size(173, 23);
            this.ChkEmpresa8.TabIndex = 42;
            this.ChkEmpresa8.Text = "EA Entretenimento Filial";
            this.ChkEmpresa8.UseVisualStyleBackColor = true;
            // 
            // ChkTodos
            // 
            this.ChkTodos.AutoSize = true;
            this.ChkTodos.Enabled = false;
            this.ChkTodos.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkTodos.Location = new System.Drawing.Point(9, 98);
            this.ChkTodos.Name = "ChkTodos";
            this.ChkTodos.Size = new System.Drawing.Size(63, 23);
            this.ChkTodos.TabIndex = 36;
            this.ChkTodos.Text = "Todas";
            this.ChkTodos.UseVisualStyleBackColor = true;
            // 
            // ChkEmpresa1
            // 
            this.ChkEmpresa1.AutoSize = true;
            this.ChkEmpresa1.Enabled = false;
            this.ChkEmpresa1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkEmpresa1.Location = new System.Drawing.Point(8, 28);
            this.ChkEmpresa1.Name = "ChkEmpresa1";
            this.ChkEmpresa1.Size = new System.Drawing.Size(114, 23);
            this.ChkEmpresa1.TabIndex = 41;
            this.ChkEmpresa1.Text = "Ocktus Matriz";
            this.ChkEmpresa1.UseVisualStyleBackColor = true;
            // 
            // ChkEmpresa3
            // 
            this.ChkEmpresa3.AutoSize = true;
            this.ChkEmpresa3.Enabled = false;
            this.ChkEmpresa3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkEmpresa3.Location = new System.Drawing.Point(168, 28);
            this.ChkEmpresa3.Name = "ChkEmpresa3";
            this.ChkEmpresa3.Size = new System.Drawing.Size(113, 23);
            this.ChkEmpresa3.TabIndex = 40;
            this.ChkEmpresa3.Text = "Instituto Exito";
            this.ChkEmpresa3.UseVisualStyleBackColor = true;
            // 
            // ChkEmpresa4
            // 
            this.ChkEmpresa4.AutoSize = true;
            this.ChkEmpresa4.Enabled = false;
            this.ChkEmpresa4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkEmpresa4.Location = new System.Drawing.Point(168, 64);
            this.ChkEmpresa4.Name = "ChkEmpresa4";
            this.ChkEmpresa4.Size = new System.Drawing.Size(140, 23);
            this.ChkEmpresa4.TabIndex = 39;
            this.ChkEmpresa4.Text = "Temmus Educação";
            this.ChkEmpresa4.UseVisualStyleBackColor = true;
            // 
            // ChkEmpresa6
            // 
            this.ChkEmpresa6.AutoSize = true;
            this.ChkEmpresa6.Enabled = false;
            this.ChkEmpresa6.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkEmpresa6.Location = new System.Drawing.Point(344, 64);
            this.ChkEmpresa6.Name = "ChkEmpresa6";
            this.ChkEmpresa6.Size = new System.Drawing.Size(104, 23);
            this.ChkEmpresa6.TabIndex = 38;
            this.ChkEmpresa6.Text = "JD Educação";
            this.ChkEmpresa6.UseVisualStyleBackColor = true;
            // 
            // ChkEmpresa5
            // 
            this.ChkEmpresa5.AutoSize = true;
            this.ChkEmpresa5.Enabled = false;
            this.ChkEmpresa5.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkEmpresa5.Location = new System.Drawing.Point(344, 28);
            this.ChkEmpresa5.Name = "ChkEmpresa5";
            this.ChkEmpresa5.Size = new System.Drawing.Size(159, 23);
            this.ChkEmpresa5.TabIndex = 37;
            this.ChkEmpresa5.Text = "JD Business Academy";
            this.ChkEmpresa5.UseVisualStyleBackColor = true;
            // 
            // ChkEmpresa2
            // 
            this.ChkEmpresa2.AutoSize = true;
            this.ChkEmpresa2.Enabled = false;
            this.ChkEmpresa2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.ChkEmpresa2.Location = new System.Drawing.Point(8, 64);
            this.ChkEmpresa2.Name = "ChkEmpresa2";
            this.ChkEmpresa2.Size = new System.Drawing.Size(101, 23);
            this.ChkEmpresa2.TabIndex = 35;
            this.ChkEmpresa2.Text = "Ocktus Filial";
            this.ChkEmpresa2.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(441, 484);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 35);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // GpDados
            // 
            this.GpDados.Controls.Add(this.DgvUsuarios);
            this.GpDados.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.GpDados.Location = new System.Drawing.Point(18, 277);
            this.GpDados.Name = "GpDados";
            this.GpDados.Size = new System.Drawing.Size(743, 186);
            this.GpDados.TabIndex = 91;
            this.GpDados.TabStop = false;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(9, 22);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(723, 148);
            this.DgvUsuarios.TabIndex = 85;
            this.DgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellContentClick);
            this.DgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label4.Location = new System.Drawing.Point(25, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 92;
            this.label4.Text = "Nome:";
            // 
            // CmbNome
            // 
            this.CmbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbNome.Enabled = false;
            this.CmbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNome.FormattingEnabled = true;
            this.CmbNome.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.CmbNome.Location = new System.Drawing.Point(21, 31);
            this.CmbNome.Margin = new System.Windows.Forms.Padding(4);
            this.CmbNome.Name = "CmbNome";
            this.CmbNome.Size = new System.Drawing.Size(493, 27);
            this.CmbNome.TabIndex = 0;
            // 
            // FrmCadUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 541);
            this.Controls.Add(this.CmbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GpDados);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.CmbAcesso);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuarios";
            this.Load += new System.EventHandler(this.FrmCadUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GpDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BtnNovo;
        internal System.Windows.Forms.ComboBox CmbAcesso;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtSenha;
        internal System.Windows.Forms.TextBox TxtUsuario;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnSalvar;
        internal System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.CheckBox ChkEmpresa7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkEmpresa3;
        private System.Windows.Forms.CheckBox ChkEmpresa4;
        private System.Windows.Forms.CheckBox ChkEmpresa6;
        private System.Windows.Forms.CheckBox ChkEmpresa5;
        private System.Windows.Forms.CheckBox ChkTodos;
        private System.Windows.Forms.CheckBox ChkEmpresa2;
        internal System.Windows.Forms.Button BtnCancelar;
        internal System.Windows.Forms.GroupBox GpDados;
        internal System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.CheckBox ChkEmpresa8;
        private System.Windows.Forms.CheckBox ChkEmpresa1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox CmbNome;
    }
}