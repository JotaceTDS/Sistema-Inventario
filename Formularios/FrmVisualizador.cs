using Microsoft.Reporting.WinForms;
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
    public partial class FrmVisualizador : Form
    {
        private DataTable dados;
        public FrmVisualizador(DataTable tabela)
        {
            InitializeComponent();
            this.dados = tabela;
        }

        private void FrmVisualizador_Load(object sender, EventArgs e)
        {

            // Configura a fonte de dados do ReportViewer
            ReportDataSource rds = new ReportDataSource("DataSetRelatorios", dados);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
