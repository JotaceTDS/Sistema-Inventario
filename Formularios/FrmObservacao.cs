using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Formularios
{
    public partial class FrmObservacao : Form
    {
        public string Observacao { get; private set; }
        public FrmObservacao(string textoInicial = "")
        {
            InitializeComponent();
            txtObservacao.Text = textoInicial;
        }

        private void FrmObservacao_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Observacao = txtObservacao.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
