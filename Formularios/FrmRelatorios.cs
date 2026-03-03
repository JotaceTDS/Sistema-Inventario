using Inventario.Classes;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class FrmRelatorios : Form
    {
        public FrmRelatorios()
        {
            InitializeComponent();
            CarregarCombos();
        }

        private void CarregarCombos()
        {
            BancoUtil.CarregarCombo(cmbEmpresa, "empresa", "id", "fantasia", incluirEmBranco: true, textoEmBranco: "— Todas —");
            // cmbStatus.Items.Clear();
            //cmbStatus.Items.Add("Ativo");
            //cmbStatus.Items.Add("Inativo");
            //cmbStatus.SelectedIndex = 0;
        }
        private void FrmRelatorios_Load(object sender, EventArgs e)
        {           
            BancoUtil.CarregarCombo(cmbEmpresa, "empresa", "id", "fantasia", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(cmbUsuario, "funcionarios", "id", "nome", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(cmbProdutos, "estoque", "id", "descricao", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string empresaId = cmbEmpresa.SelectedValue?.ToString();
            string produtoId = cmbProdutos.SelectedValue?.ToString();
            string usuarioId = cmbUsuario.SelectedValue?.ToString();
           
            //Montar filtros opcionais
            var filtros = new Dictionary<string, object>();
            
            if (!string.IsNullOrEmpty(empresaId)) filtros.Add("empresa", empresaId);            
            if (!string.IsNullOrEmpty(produtoId)) filtros.Add("id", produtoId);
            if (!string.IsNullOrEmpty(usuarioId)) filtros.Add("usuario_id", usuarioId);

            //Busca dados da tabela estoque
            DataTable dt = new DataTable();
            Conexao conexaoDB = new Conexao();
            using (var conn = conexaoDB.Abrir())
            {
                if (conn == null) return;

                string where = "(deletado IS NULL OR deletado = '')";

                var parametros = new List<MySql.Data.MySqlClient.MySqlParameter>();
                foreach (var filtro in filtros)
                {
                    where += $" AND {filtro.Key} = @{filtro.Key}";
                    parametros.Add(new MySql.Data.MySqlClient.MySqlParameter($"@{filtro.Key}", filtro.Value));
                }
                string sql = $"SELECT * FROM estoque WHERE {where} ORDER BY descricao";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parametros.ToArray());
                    using (var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                FrmVisualizador visualizador = new FrmVisualizador(dt);
                visualizador.ShowDialog();


            }




        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    
    }
}
