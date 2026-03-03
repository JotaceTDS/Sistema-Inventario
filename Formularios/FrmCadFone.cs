using Inventario.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2010.PowerPoint;
using MySql.Data.MySqlClient;

namespace Inventario.Formularios
{
    public partial class FrmCadFone : Form
    {
        private int? idSelecionado = null;

        public FrmCadFone()
        {
            InitializeComponent();
        }
        private void FrmCadFone_Load(object sender, EventArgs e)
        {
            
            BancoUtil.ExecutarConsulta
            (
                tabela: "telefones",
                grid: DgvTelefones,
                colunas: "id, empresa, nome, linha, conta, dados, situacao, tp_chip, operadora, valor, vencimento, vigencia",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC"
            );

            BancoUtil.CarregarCombo(CmbEmpresa, "empresa", "id", "fantasia");
            BancoUtil.CarregarCombo(CmbNome, "funcionarios", "id", "nome");
            BancoUtil.CarregarCombo(CmbPesquisa, "empresa", "id", "fantasia");
            FormUtil.FormatarCodigo(DgvTelefones);
            FormUtil.FormatarMoeda(TxtValor);
            FormUtil.AplicarAvancoComEnter(this);
            DgvTelefones.CellFormatting += DgvTelefones_CellFormatting;
            FormatarGrid();
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);

            CmbPesquisa.Enabled = true;
            BtnFiltrar.Enabled = true;
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
            
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, true);
           
            DgvTelefones.ClearSelection();
            DgvTelefones.CurrentCell = null;
            idSelecionado = null;

            CmbPesquisa.Enabled = false;
            TxtPesquisa.Enabled = false;
            BtnNovo.Enabled = false;
            BtnFiltrar.Enabled = false;
            RdbNome.Enabled = false;
            RdbLinha.Enabled = false;
            CmbEmpresa.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio())
            {
                return;
            }

            string numeroLinha = FormUtil.RemoverMascara(TxtLinha.Text);

            var campos = new Dictionary<string, object>
            {
                {"empresa", CmbEmpresa.Text},
                {"nome", CmbNome.Text},
                {"linha", FormUtil.RemoverMascara(TxtLinha.Text) },
                {"conta", CmbConta.Text },
                {"dados", CmbDados.Text},
                {"situacao", CmbSituacao.Text},
                {"tp_chip", CmbTpChip.Text},
                {"operadora", CmbOpera.Text},
                { "valor", string.IsNullOrWhiteSpace(TxtValor.Text) ? 0m : BancoUtil.ConverterMoedaParaDecimal(TxtValor.Text) },
                {"vencimento", TxtVencimento.Text},
                {"vigencia",TxtVigPlano.Text }
            };

            if (idSelecionado == null)
            {
                bool linhaDuplicada = BancoUtil.RegistroExiste("telefones", new Dictionary<string, object> { { "linha", numeroLinha } });
                if (linhaDuplicada)
                {
                    MessageBox.Show("Já existe um registro com esse número de linha...!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtLinha.Focus();
                    return;
                }                                     
                BancoUtil.InserirRegistro("telefones", campos);
                MessageBox.Show("Registro salvo com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool linhaDuplicada = BancoUtil.EditarSemDuplicidade("telefones", new Dictionary<string, object> { { "linha", numeroLinha } }, "id", idSelecionado.Value);
                if (linhaDuplicada)
                {
                    MessageBox.Show("Já existe um registro com esse número de linha...!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtLinha.Focus();
                    return;
                }
                BancoUtil.AtualizarRegistro("telefones", campos, "id", idSelecionado);
                MessageBox.Show("Registro atualizado com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
            BancoUtil.ExecutarConsulta
            (
                tabela: "telefones",
                grid: DgvTelefones,
                colunas: "id, empresa, nome, linha, conta, dados, situacao, tp_chip, operadora, valor, vencimento, vigencia",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC"
            );

            FormUtil.FormatarCodigo(DgvTelefones);
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = true;
            FormatarGrid();
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            BancoUtil.ExecutarConsulta
            (
                tabela: "telefones",
                grid: DgvTelefones,
                colunas: "id, empresa, nome, linha, conta, dados, situacao, tp_chip, operadora, valor, vencimento, vigencia",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC"
            );

            FormUtil.FormatarCodigo(DgvTelefones);
            FormUtil.FormatarMoeda(TxtValor);
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);

            CmbPesquisa.Enabled = true;
            BtnNovo.Enabled = true;
            BtnFiltrar.Enabled = true;            
            TxtPesquisa.Enabled = true;
            RdbNome.Enabled = true;
            RdbLinha.Enabled = true;

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvTelefones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            idSelecionado = Convert.ToInt32(DgvTelefones.SelectedRows[0].Cells["id"].Value);

            DialogResult resposta = MessageBox.Show("Deseja excluir o resitro selecionado ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                var campos = new Dictionary<string, object>
                {
                    {"deletado", 1 }
                };
                BancoUtil.AtualizarRegistro("telefones", campos, "id", idSelecionado);
                FormUtil.FormatarCodigo(DgvTelefones);
 
                BancoUtil.ExecutarConsulta
                (
                    tabela: "telefones",
                    grid: DgvTelefones,
                    colunas: "id, empresa, nome, linha, conta, dados, situacao, tp_chip, operadora, valor, vencimento, vigencia",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "empresa ASC"
                );

                MessageBox.Show("Registro excluido com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormatarGrid();
                FormUtil.HabilitarCampos(this, false);
            }
        }
        private void FormatarGrid()
        {
            var configuracoesEmpresas = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
            {
                { "id", ("Código", 50, true) }, // Essa será ocultada
                { "empresa", ("Empresa", 130, true) },
                { "nome", ("Usuario", 180, true) },
                { "linha", ("Nº Linha", 90, true) },
                { "conta", ("Conta", 80, true) },
                { "dados", ("Banda", 50, true) },
                { "situacao", ("Situação", 60, true) },
                { "tp_chip", ("Chip", 70, true) },
                { "operadora", ("Operadora", 50, true) },
                { "valor", ("Valor", 70, true) },
                { "vencimento", ("Vencto", 50, true) },
                { "vigencia", ("Vigência", 80, true) }
            };
            FormUtil.FormatarGridGenerico(DgvTelefones, configuracoesEmpresas);
            FormUtil.FormatarCodigo(DgvTelefones, "id");
            DgvTelefones.RowHeadersVisible = false;
        }
     
        private bool CampoObrigatorio()
        {
            if (string.IsNullOrWhiteSpace(CmbEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtLinha.Text) ||
                string.IsNullOrWhiteSpace(CmbConta.Text))

            {
                MessageBox.Show("Preencha todos os campos obrigatórios...!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
 
            return true;
        }

        private void DgvTelefones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvTelefones.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = DgvTelefones.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);

                CmbEmpresa.Text = row.Cells["empresa"].Value?.ToString();
                CmbNome.Text = row.Cells["nome"].Value?.ToString();
                TxtLinha.Text = row.Cells["linha"].Value.ToString();
                CmbConta.Text = row.Cells["conta"].Value?.ToString();
                CmbDados.Text = row.Cells["dados"].Value?.ToString();
                CmbSituacao.Text = row.Cells["situacao"].Value?.ToString();
                CmbTpChip.Text = row.Cells["tp_chip"].Value?.ToString();
                CmbOpera.Text = row.Cells["operadora"].Value?.ToString();
                TxtValor.Text = row.Cells["valor"].Value?.ToString();
                //txtValor.Text = BancoUtil.FormatarMoeda(row.Cells["valor"].Value?.ToString());
                TxtVencimento.Text = row.Cells["vencimento"].Value?.ToString();
                TxtVigPlano.Text = row.Cells["vigencia"].Value?.ToString();

                FormUtil.HabilitarCampos(this, true);
            }
        }

        private void DgvTelefones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (DgvTelefones.Columns[e.ColumnIndex].Name == "linha" && e.Value != null)
            {
                string tel = FormUtil.RemoverMascara(e.Value.ToString());
                if (tel.Length == 11)
                    e.Value = Convert.ToUInt64(tel).ToString(@"(00) 00000-0000");
                else if (tel.Length == 10)
                    e.Value = Convert.ToUInt64(tel).ToString(@"(00) 0000-0000");

                e.FormattingApplied = true;
            }


            if (DgvTelefones.Columns[e.ColumnIndex].Name == "valor" && e.Value != null && e.Value.ToString() != "")
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                {
                    e.Value = valor.ToString("C2"); // R$ 0,00
                    e.FormattingApplied = true;
                }
            }

        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string campo = "";

            if (RdbNome.Checked)
                campo = "nome";
            else if (RdbLinha.Checked)
                campo = "linha";

            if (string.IsNullOrEmpty(campo)) return;

            BancoUtil.PesquisarPorCampo("telefones", campo, TxtPesquisa.Text.Trim(), DgvTelefones, "id, empresa, nome, linha, conta, dados, situacao, tp_chip, operadora, valor, vencimento, vigencia");
  
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string campo = CmbPesquisa.Text.Trim();
            if (string.IsNullOrEmpty(campo))
            {
                MessageBox.Show("Selecione um campo para filtrar...!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BancoUtil.PesquisarPorCampo("telefones", "empresa", campo, DgvTelefones, "id, empresa, nome, linha, conta, dados, situacao, tp_chip, operadora, valor, vencimento, vigencia");
            BtnCancelar.Enabled = true;

        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                txt.TextChanged -= TxtValor_TextChanged; // Remove o evento para evitar loop
                //FormUtil.FormatarMoeda(TxtValor.Text);
                txt.TextChanged += TxtValor_TextChanged; // Reanexa o evento

            }
        }

        private void DgvTelefones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
