

using Inventario.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Inventario.Formularios
{
    public partial class FrmCargo : Form
    {
        private int? idSelecionado = null;

        public FrmCargo()
        {
            InitializeComponent();
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            BancoUtil.ExecutarConsulta
            (
                tabela: "cargo",
                grid: DgvCargo,
                colunas: "id, nome",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "id ASC, nome ASC"
            );

            FormUtil.FormatarCodigo(DgvCargo, "id");
            FormUtil.AplicarAvancoComEnter(this);
            FormUtil.HabilitarCampos(this, false);
            FormUtil.AplicarPermissoes(this);
            
            if (SessaoUsuario.EhAdmin)
            {
                BtnNovo.Enabled = true;
            };

            FormatarGrid();
                    
        }

        private void CarregarDados()
        {
            try
            {
                // Muda o mouse para o ícone de carregamento
                this.Cursor = Cursors.WaitCursor;

                BancoUtil.ExecutarConsulta(
                    tabela: "cargo",
                    grid: DgvCargo,
                    colunas: "id, nome",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "nome"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cargos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaura o cursor padrão
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            idSelecionado = null;
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, true);
            FormUtil.AplicarPermissoes(this);
            TxtNome.Focus();
            BtnNovo.Enabled = false;
            DgvCargo.ClearSelection();
            DgvCargo.CurrentCell = null;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio())
            {
                return;
            }

            var campos = new Dictionary<string, object>
            {
                { "nome", TxtNome.Text.Trim() }
            };

            try
            {
                if (idSelecionado == null)
                {
                    BancoUtil.InserirRegistro("nome", campos);
                    MessageBox.Show("Cargo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BancoUtil.AtualizarRegistro("cargo", campos, "id", idSelecionado.Value);
                    MessageBox.Show("Cargo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                BancoUtil.ExecutarConsulta(
                    tabela: "cargo",
                    grid: DgvCargo,
                    colunas: "id, nome",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "nome"
                );
                FormUtil.FormatarCodigo(DgvCargo, "id");
                FormUtil.AplicarAvancoComEnter(this);
                FormUtil.HabilitarCampos(this, false);
                FormUtil.AplicarPermissoes(this);
                FormUtil.LimparCampos(this);
                BtnNovo.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cargo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            idSelecionado = null;
            //FormUtil.LimparCampos(this);
            //FormUtil.HabilitarCampos(this, false);
            //FormUtil.AplicarPermissoes(this);
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            //TxtPesquisa.Enabled = true;
            BtnNovo.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private bool CampoObrigatorio()
                    {
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                MessageBox.Show("O campo 'Cargo' é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }
            return true;
        }

        private void DgvCargo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvCargo.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = DgvCargo.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);
                TxtCodigo.Text = idSelecionado.Value.ToString("D6");
                TxtNome.Text = row.Cells["nome"].Value?.ToString();

                FormUtil.HabilitarCampos(this, true);
                FormUtil.AplicarPermissoes(this);
            }
        }

        private void DgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, true);
            FormUtil.AplicarPermissoes(this);
        }

        private void FormatarGrid()
        {
            if (DgvCargo.Columns.Count == 0)
                return;

            try
            {
                var configuracoesCargo = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
                {
                    { "id", ("Código", 70, true) },
                    { "nome", ("Cargo", 250, true) }
                };
                FormUtil.FormatarGridGenerico(DgvCargo, configuracoesCargo);
                FormUtil.FormatarCodigo(DgvCargo, "id");
                DgvCargo.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao formatar o grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}

