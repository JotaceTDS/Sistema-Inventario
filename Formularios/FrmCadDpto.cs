using Inventario.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

namespace Inventario.Formularios
{
    public partial class FrmCadDpto : Form
    {
        private int? idSelecionado = null;
        public FrmCadDpto()
        {
            InitializeComponent();
        }

        private void FrmCadDpto_Load(object sender, EventArgs e)
        {
            BancoUtil.ExecutarConsulta
            (
                tabela: "departamentos",
                grid: DgvDpto,
                colunas: "id, descricao",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "descricao ASC"
            );

            FormUtil.FormatarCodigo(DgvDpto);
            FormUtil.AplicarAvancoComEnter(this);
            //dgvDpto.CellFormatting += dgvDpto_CellFormatting;           
            FormatarGrid();
            FormUtil.HabilitarCampos(this, false);
            FormUtil.AplicarPermissoes(this);
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, true);
            DgvDpto.ClearSelection();
            DgvDpto.CurrentCell = null; // Remove seleção da célula
            TxtDescricao.Focus();
            idSelecionado = null; // Limpa o ID selecionado
            BtnNovo.Enabled = false; // Desabilita o botão Novo para evitar múltiplos cliques
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio())
            {
                return;
            }

            var campos = new Dictionary<string, object>
            {
                { "descricao", TxtDescricao.Text.Trim() }
            };

            try
            {
                if (idSelecionado == null)
                {
                    // Inserção
                    BancoUtil.InserirRegistro("departamentos", campos);
                    MessageBox.Show("Departamento inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                  
                    BancoUtil.AtualizarRegistro("departamentos", campos, "campos", idSelecionado);
                    MessageBox.Show("Departamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                BancoUtil.ExecutarConsulta
                (
                    tabela: "departamentos",
                    grid: DgvDpto,
                    colunas: "id, descricao",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "descricao ASC"
                );
                FormUtil.FormatarCodigo(DgvDpto);
                FormUtil.HabilitarCampos(this, false);
                FormUtil.LimparCampos(this);
                BtnNovo.Enabled = true; // Reabilita o botão Novo após salvar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o departamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
        }

        private void BtnCancelar_Click1(object sender, EventArgs e)
        {
            
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = true; // Reabilita o botão Novo após cancelar
            FormatarGrid();

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            {
                if (DgvDpto.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione um departamento para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                idSelecionado = Convert.ToInt32(DgvDpto.SelectedRows[0].Cells["id"].Value);

                DialogResult resposta = MessageBox.Show("Deseja excluir o departamento selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        var campos = new Dictionary<string, object>
                    {
                        { "deletado", 1}
                    };
                        BancoUtil.AtualizarRegistro("departamentos", campos, "id", idSelecionado);

                        BancoUtil.ExecutarConsulta
                        (
                            tabela: "departamentos",
                            grid: DgvDpto,
                            colunas: "id, descricao",
                            filtrosObrigatorios: null,
                            filtrosOpcionais: null,
                            orderBy: "descricao ASC"
                        );
                        FormUtil.FormatarCodigo(DgvDpto);
                        MessageBox.Show("Departamento excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormUtil.HabilitarCampos(this, false);
                        FormUtil.LimparCampos(this);
                        BtnNovo.Enabled = true; // Reabilita o botão Novo após exclusão
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o departamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
     
        private bool CampoObrigatorio()
        {
            if (string.IsNullOrWhiteSpace(TxtDescricao.Text))
            {
                MessageBox.Show("O campo 'Descrição' é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDescricao.Focus();
                return false;
            }
            return true;
        }

        private void FormatarGrid()
        {
            var configuracoesDpto = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
            {
                {"id", ("Código", 50, true) },
                {"descricao", ("Descrição", 200, true) }
            };
            FormUtil.FormatarGridGenerico(DgvDpto, configuracoesDpto);
            FormUtil.FormatarCodigo(DgvDpto, "id");
            DgvDpto.RowHeadersVisible = false;
        }
        //private void LimparCampos()
        //{
        //    TxtCodigo.Clear();
        //    TxtDescricao.Clear();
        //}

        private void DgvDpto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvDpto.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = DgvDpto.Rows[e.RowIndex];
                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);
                TxtCodigo.Text = row.Cells["id"].Value.ToString();
                TxtDescricao.Text = row.Cells["descricao"].Value.ToString();
                FormUtil.HabilitarCampos(this, true);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = true; // Reabilita o botão Novo após cancelar
        }
    }

}

