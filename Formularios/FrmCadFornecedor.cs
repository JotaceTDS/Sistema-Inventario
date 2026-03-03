using Inventario.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Management;
using Newtonsoft.Json;
using System.Net.Http;
using System.Globalization;


namespace Inventario.Formularios
{
    public partial class FrmCadFornecedor : Form
    {
        private int? idSelecionado = null;

        public FrmCadFornecedor()
        {
            InitializeComponent();
            this.TxtCep.Leave += new System.EventHandler(this.TxtCep_Leave);
        }

        private void FrmCadFornecedor_Load(object sender, EventArgs e)
        {

            BancoUtil.ExecutarConsulta
            (
                tabela: "fornecedor",
                grid: DgvFornecedor,
                colunas: "id, cnpj, ie, razao, fantasia, cep, endereco, bairro, cidade, uf, email, fone, contato",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "id ASC, razao ASC"

            );
            FormUtil.FormatarCodigo(DgvFornecedor);
            FormUtil.AplicarAvancoComEnter(this);
            DgvFornecedor.CellFormatting += DgvFornecedor_CellFormatting;
            FormatarGrid();
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            TxtPesquisa.Enabled = true; 
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
        }
        
        private void BtnNovo_Click(object sender, EventArgs e)
        {            
            FormUtil.HabilitarCampos(this);
            FormUtil.LimparCampos(this);
            TxtCnpj.Focus();
            TxtPesquisa.Enabled = false;

            BtnNovo.Enabled = false;
            DgvFornecedor.ClearSelection();
            DgvFornecedor.CurrentCell = null;
            idSelecionado = null; // Limpa a seleção do ID
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CamposObrigatorios())
                return;

            string cnpj = FormUtil.RemoverMascara(TxtCnpj.Text);
            //string razao = txtRazao.Text.Trim();
            
            var campos = new Dictionary<string, object>
            {
                {"cnpj", FormUtil.RemoverMascara(TxtCnpj.Text) },
                {"ie", FormUtil.RemoverMascara(TxtIe.Text) },
                {"razao", TxtRazao.Text },
                {"fantasia", TxtFantasia.Text },
                {"cep", FormUtil.RemoverMascara(TxtCep.Text) },
                {"endereco", TxtEndereco.Text },
                {"bairro", TxtBairro.Text },
                {"cidade", TxtCidade.Text },
                {"uf", TxtUf.Text },
                {"email", TxtEmail.Text },
                {"fone", FormUtil.RemoverMascara(TxtTelefone.Text) },
                {"contato", TxtContato.Text }
            };

            if (idSelecionado == null)
            {
                bool cnpjDuplicado = BancoUtil.RegistroExiste("fornecedor", new Dictionary<string, object> { { "cnpj", cnpj } });
                if (cnpjDuplicado)
                {
                    MessageBox.Show("Já existe um fornecedor cadastrado com o mesmo CNPJ ou Razão Social.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCnpj.Focus();
                    return;
                }
                BancoUtil.InserirRegistro("fornecedor", campos);
                FormUtil.FormatarCodigo(DgvFornecedor);
                MessageBox.Show("Registro salvo com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool cnpjDuplicado = BancoUtil.EditarSemDuplicidade("fornecedor", new Dictionary<string, object> { { "cnpj", cnpj } }, "id", idSelecionado.Value);
                if (cnpjDuplicado)
                {
                    MessageBox.Show("Já existe um fornecedor cadastrado com o mesmo CNPJ ou Razão Social.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCnpj.Focus();
                    return;
                }                
                BancoUtil.AtualizarRegistro("fornecedor", campos, "id", idSelecionado);
                FormUtil.FormatarCodigo(DgvFornecedor);
                MessageBox.Show("Registro Atualizado com sucesso...!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BancoUtil.ExecutarConsulta
            (
                tabela: "fornecedor",
                grid: DgvFornecedor,
                colunas: "id, cnpj, ie, razao, fantasia, cep, endereco, bairro, cidade, uf, email, fone, contato",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "razao ASC"
            );

            FormUtil.FormatarCodigo(DgvFornecedor);
            FormatarGrid();
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormUtil.HabilitarCampos(this, false);
            FormUtil.LimparCampos(this);
            TxtPesquisa.Enabled = true;
            BtnNovo.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvFornecedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            idSelecionado = Convert.ToInt32(DgvFornecedor.SelectedRows[0].Cells["id"].Value);

            DialogResult resposta = MessageBox.Show("Deseja excluir o registro selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                var campos = new Dictionary<string, object>
                {
                    {"deletado", 1 }
                };
                BancoUtil.AtualizarRegistro("fornecedor", campos, "id", idSelecionado);                
                
                BancoUtil.ExecutarConsulta
                (
                    tabela: "fornecedor",
                    grid: DgvFornecedor,
                    colunas: "id, cnpj, ie, razao, fantasia, cep, endereco, bairro, cidade, uf, email, fone, contato",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "razao ASC"
                );

                FormUtil.FormatarCodigo(DgvFornecedor);
                MessageBox.Show("Registro excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormUtil.LimparCampos(this);
                FormUtil.HabilitarCampos(this, false);
            }
        }
               private void FormatarGrid()
        {
            var configuracoesEmpresas = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
                {
                { "id", ("Código", 50, true) },
                { "cnpj", ("CNPJ", 110, true) },
                { "ie", ("IE", 90, true) },
                { "razao", ("Razão Social", 180, true) },
                { "fantasia", ("Fantasia", 150, true) },
                { "cep", ("CEP", 80, true) },
                { "endereco", ("Endereço", 150, true) },
                { "bairro", ("Bairro", 100, true) },
                { "cidade", ("Cidade", 80, true) },
                { "uf", ("UF", 35, true) },
                { "email", ("E-mail", 150, true) },
                { "fone", ("Telefone", 100, true) },
                { "contato", ("Contato", 100, true) }
            };

            FormUtil.FormatarGridGenerico(DgvFornecedor, configuracoesEmpresas);
            FormUtil.FormatarCodigo(DgvFornecedor, "id");
            DgvFornecedor.RowHeadersVisible = false;
        }
        private bool CamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(TxtCnpj.Text) || string.IsNullOrWhiteSpace(TxtRazao.Text) || string.IsNullOrWhiteSpace(TxtFantasia.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios: CNPJ, Razão Social e Nome Fantasia.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void DgvFornecedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {             
            if (e.Value == null) return;

            string columnName = DgvFornecedor.Columns[e.ColumnIndex].Name;
            string valor = e.Value.ToString();

            var formatadores = new Dictionary<string, Func<string, string>>()
            {
                { "cnpj", FormUtil.FormatarCnpj },
                { "ie", FormUtil.FormatarIE },
                { "cep", FormUtil.FormatarCep },
                { "fone", FormUtil.FormatarTelefone }
            };

            if (formatadores.ContainsKey(columnName))
            {
                e.Value = formatadores[columnName](valor);
                e.FormattingApplied = true;
            }
        }

        private void DgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvFornecedor.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = DgvFornecedor.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);

                TxtCnpj.Text = row.Cells["cnpj"].Value.ToString();
                TxtIe.Text = row.Cells["ie"].Value.ToString();
                TxtRazao.Text = row.Cells["razao"].Value.ToString();
                TxtFantasia.Text = row.Cells["fantasia"].Value.ToString();
                TxtCep.Text = row.Cells["cep"].Value.ToString();
                TxtEndereco.Text = row.Cells["endereco"].Value.ToString();
                TxtBairro.Text = row.Cells["bairro"].Value.ToString();
                TxtCidade.Text = row.Cells["cidade"].Value.ToString();
                TxtUf.Text = row.Cells["uf"].Value.ToString();
                TxtEmail.Text = row.Cells["email"].Value.ToString();
                TxtTelefone.Text = row.Cells["fone"].Value.ToString();
                TxtContato.Text = row.Cells["contato"].Value.ToString();
                FormUtil.HabilitarCampos(this);
            }
        }

        private async void TxtCep_Leave(object sender, EventArgs e)
        {
            string cep = FormUtil.RemoverMascara(TxtCep.Text);

            if (cep.Length !=8)
                return;

            var endereco = await Endereco.BuscaEnderecoPorCep(cep);

            if (endereco != null && string.IsNullOrEmpty(endereco.cep) == false)
            {
                TxtEndereco.Text = endereco.logradouro;
                TxtBairro.Text = endereco.bairro;
                TxtCidade.Text = endereco.localidade;
                TxtUf.Text = endereco.uf;
            }
            else
            {
                MessageBox.Show("CEP não encontrado ou inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string campo = "";

            if (rdbCnpj.Checked)
                campo = "cnpj";
            else if (rdbRazao.Checked)
                campo = "razao";
            
           if (string.IsNullOrEmpty(campo)) return;

           BancoUtil.PesquisarPorCampo("fornecedor", campo, TxtPesquisa.Text.Trim(), DgvFornecedor, "id, cnpj, ie, razao, fantasia, email, endereco, fone, contato");
            FormUtil.FormatarCodigo(DgvFornecedor);            
        }

        private void DgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUtil.HabilitarCampos(this, false);
            FormUtil.LimparCampos(this);
        }
    }
}
