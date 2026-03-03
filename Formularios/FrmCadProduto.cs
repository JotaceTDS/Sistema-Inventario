using Inventario.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario.Formularios
{
    public partial class FrmCadProduto : Form
    {
        private int? idSelecionado = null; // Variável para armazenar o ID do produto selecionado
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            BancoUtil.ExecutarConsulta
            (
                tabela: "produto",
                grid: DgvProdutos,
                colunas: "id, descricao, marca, modelo, imagem",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy : "id ASC, descricao ASC, marca ASC, modelo ASC"
            );

            FormUtil.FormatarCodigo(DgvProdutos, "id");
            //dgvProdutos.CellFormatting += dgvProdutos_CellFormatting;
            FormUtil.AplicarAvancoComEnter(this);
            FormatarGrid();
            FormUtil.HabilitarCampos(this, false);

            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            
            LimparCampos();
            HabilitarCampos();
            idSelecionado = null;
            txtDescricao.Focus(); // Foca no campo de descrição ao habilitar os campos
            DgvProdutos.ClearSelection(); // Limpa a seleção da grid
            DgvProdutos.CurrentCell = null; // Remove a seleção da célula atual

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CamposObrigatorios())
                return;

            string descricao = txtDescricao.Text.Trim();
            string marca = txtMarca.Text.Trim();
            string modelo = txtModelo.Text.Trim();

            var filtros = new Dictionary<string, object>
            {
                {"descricao", descricao },
                {"marca", marca },
                {"modelo", modelo }
            };
            if (idSelecionado ==null)
            {
                // Verifica se já existe um produto com a mesma descrição, marca e modelo
                if (BancoUtil.RegistroExiste("produto", filtros))
                {
                    MessageBox.Show("Já existe um produto cadastrado com essa descrição, marca e modelo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // Se for uma atualização, não verifica a existência do registro
                filtros["id"] = idSelecionado;
            }

            byte[] imagemBytes = null; // Inicializa a variável de imagem como nula, se necessário

            if (picFoto.Image != null)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagemBytes = ms.ToArray();
                }
            }

            var campos = new Dictionary<string, object>
            {
                {"descricao", txtDescricao.Text},
                {"marca", txtMarca.Text },
                {"modelo", txtModelo.Text },
                {"imagem", imagemBytes } // Adiciona a imagem como byte array, se necessário
            };

            if (idSelecionado == null)
            {
                BancoUtil.InserirRegistro("produto", campos);
                FormUtil.FormatarCodigo(DgvProdutos);
                MessageBox.Show("Registro salvo com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BancoUtil.AtualizarRegistro("produto", campos, "id", idSelecionado);
                FormUtil.FormatarCodigo(DgvProdutos);
                MessageBox.Show("Registro Atualizado com sucesso...!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            idSelecionado = null;
            //BancoUtil.ListarTabela("produto", dgvProdutos, "id, descricao, marca, modelo, imagem", null, false, "descricao ASC");
            BancoUtil.ExecutarConsulta
            (
                tabela: "produto",
                grid: DgvProdutos,
                colunas: "id, descricao, marca, modelo, imagem",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "descricao ASC"
            );
            LimparCampos();
            FormatarGrid();
            FormUtil.HabilitarCampos(this, false);

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            idSelecionado = null;
            LimparCampos();
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            idSelecionado = Convert.ToInt32(DgvProdutos.SelectedRows[0].Cells["id"].Value);

            DialogResult resposta = MessageBox.Show("Deseja excluir o produto selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                var campos = new Dictionary<string, object>
                {                  
                    {"deletado", 1}
                };
                BancoUtil.AtualizarRegistro("produto", campos, "id", idSelecionado);
                //BancoUtil.ListarTabela("produto", dgvProdutos, "id, descricao, marca, modelo, imagem");
                FormUtil.FormatarCodigo(DgvProdutos);
                MessageBox.Show("Produto excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtPesquisa.Enabled = false;

            if (SessaoUsuario.EhAdmin)
            {
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnExcluir.Enabled = true;
                btnAddImagem.Enabled = true;
            }

            txtDescricao.Focus(); // Foca no campo de descrição ao habilitar os campos
        }

        //private void DesabilitarCampos()
        //{
        //    txtDescricao.Enabled = false;
        //    txtMarca.Enabled = false;
        //    txtModelo.Enabled = false;
        //    txtPesquisa.Enabled = true;

        //    if (SessaoUsuario.EhAdmin)
        //    {
        //        btnNovo.Enabled = true;
        //        btnSalvar.Enabled = false;
        //        btnCancelar.Enabled = false;
        //        btnExcluir.Enabled = false;
        //        btnAddImagem.Enabled = false;
        //    }
        //}

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtPesquisa.Clear();
            picFoto.Image = null; // Limpa a imagem do PictureBox
        }

        private void FormatarGrid()
        {
            var configuracoesEmpresas = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
            {
                {  "id", ("Código", 50, true) },
                { "descricao", ("Descrição", 250, true) },
                { "marca", ("Marca", 150, true) },
                { "modelo", ("Modelo", 150, true) },
                { "imagem", ("Imagem", 100, false) } // Coluna de imagem oculta
            };

            FormUtil.FormatarGridGenerico(DgvProdutos, configuracoesEmpresas);
            DgvProdutos.RowHeadersVisible = false; // Oculta os cabeçalhos das linhas


        }

        private void DgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)       
        {
            if (e.RowIndex < 0) return; // ignora cabeçalho/linha inválida

            var row = DgvProdutos.Rows[e.RowIndex];

            if (row.Cells["id"].Value == null) return;

            // ID do produto
            if (int.TryParse(row.Cells["id"].Value.ToString(), out int id))
                idSelecionado = id;

            // Preenche campos de texto (usa null-coalescing pra evitar erro se vier nulo)
            txtDescricao.Text = row.Cells["descricao"].Value?.ToString() ?? string.Empty;
            txtMarca.Text = row.Cells["marca"].Value?.ToString() ?? string.Empty;
            txtModelo.Text = row.Cells["modelo"].Value?.ToString() ?? string.Empty;

            // Carregar imagem
            if (row.Cells["imagem"].Value != null && row.Cells["imagem"].Value != DBNull.Value)
            {
                try
                {
                    byte[] imagemBytes = (byte[])row.Cells["imagem"].Value;

                    using (var ms = new MemoryStream(imagemBytes))
                    {
                        picFoto.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    picFoto.Image = null; // caso a conversão da imagem dê erro
                }
            }
            else
            {
                picFoto.Image = null;
            }

            HabilitarCampos();
        }

        private bool CamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Informe a marca do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Informe o modelo do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Focus();
                return false;
            }

            return true;
        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUtil.HabilitarCampos(this, false);
            LimparCampos();
        }

        private void BtnAddImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Selecione uma imagem";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picFoto.Image = Image.FromFile(ofd.FileName);
                        picFoto.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta o modo de exibição da imagem
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //private void TxtPesquisa_TextChanged_2(object sender, EventArgs e)
        //{
        //    string campo = "";

        //    if (rdbDescricao.Checked)
        //        campo = "descricao";
        //    else if (rdbMarca.Checked)
        //        campo = "marca";
        //    else if (rdbModelo.Checked)
        //        campo = "modelo";

        //    if (string.IsNullOrEmpty(campo)) return;

        //    BancoUtil.PesquisarPorCampo("produto", campo, txtPesquisa.Text.Trim(), DgvProdutos, "id, descricao, marca, modelo, imagem");
        //    FormUtil.FormatarCodigo(DgvProdutos);

        //}

        private void DgvProdutos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FormUtil.HabilitarCampos(this, false);
            LimparCampos();
        }
    }
}
