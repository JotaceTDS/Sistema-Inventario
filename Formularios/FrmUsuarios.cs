using Inventario.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Newtonsoft.Json;
using System.Net.Http;

namespace Inventario.Formularios
{
    public partial class FrmCadUsers : Form
    {
        private int? idSelecionado = null;

        public FrmCadUsers()
        {
            InitializeComponent();
        }

        private void FrmCadUsers_Load(object sender, EventArgs e)
        {
            BancoUtil.ExecutarConsulta
            (
                tabela: "usuarios",
                grid: DgvUsuarios,
                colunas: "id, nome, usuario, acesso, empresas",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "id ASC, nome ASC"
            );

            BancoUtil.CarregarCombo(CmbNome, "funcionarios", "id", "nome", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
            FormUtil.AplicarAvancoComEnter(this);
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = true; // Habilita o botão Novo
            FormatarGrid();

            //Associa o ID da empresa a cada checkbox
            ChkEmpresa1.Tag = 1;
            ChkEmpresa2.Tag = 2;
            ChkEmpresa3.Tag = 3;
            ChkEmpresa4.Tag = 4;
            ChkEmpresa5.Tag = 5;
            ChkEmpresa2.Tag = 6;
            ChkEmpresa7.Tag = 7;
            ChkEmpresa6.Tag = 8;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = CmbNome.Text;
                string usuario = TxtUsuario.Text.Trim();
                string senha = TxtSenha.Text.Trim();
                string acesso = CmbAcesso.SelectedItem?.ToString() ?? "";
                string empresas = string.Join(", ", groupBox1.Controls.OfType<CheckBox>().Where(chk => chk.Checked && chk.Tag != null && chk.Text != "Todos").Select(chk => chk.Text));


                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Usuário e senha são obrigatórios.", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int usuarioId = idSelecionado.GetValueOrDefault(); // ✅ correção aqui

                if (usuarioId == 0) // INSERIR
                {
                    var campos = new Dictionary<string, object>
                    {
                        { "nome", nome },
                        { "usuario", usuario },
                        { "senha", senha },
                        { "acesso", acesso },
                        {"empresas", empresas }
                    };

                    BancoUtil.InserirRegistro("usuarios", campos);

                    // Recupera o último ID inserido
                    using (var conn = new Conexao().Abrir())
                    using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID();", conn))
                    {
                        usuarioId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                else // ATUALIZAR
                {
                    var campos = new Dictionary<string, object>
                    {
                        { "nome", nome },
                        { "usuario", usuario },
                        { "senha", senha },
                        { "acesso", acesso },
                        {"empresas", empresas }
                    };

                    BancoUtil.AtualizarRegistro("usuarios", campos, "id", usuarioId);

                    // Remove vínculos antigos
                    BancoUtil.ExcluirRegistros("usuarios_empresa", "usuario_id", usuarioId);
                }

                // Salvar vínculos com empresas
                foreach (CheckBox chk in groupBox1.Controls.OfType<CheckBox>())
                {
                    if (chk.Checked && chk.Tag != null && chk.Text != "Todos")
                    {
                        int empresaId = Convert.ToInt32(chk.Tag);

                        var camposVinculo = new Dictionary<string, object>
                        {
                            { "usuario_id", usuarioId },
                            { "empresa_id", empresaId }
                        };

                        BancoUtil.InserirRegistro("usuarios_empresa", camposVinculo);
                    }
                }

                MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BancoUtil.ExecutarConsulta
                (
                    tabela: "usuarios",
                    grid: DgvUsuarios,
                    colunas: "id, nome, usuario, acesso, empresas",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "id ASC, nome ASC"
                );

                BancoUtil.CarregarCombo(CmbNome, "funcionarios", "id", "nome", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
                FormUtil.AplicarAvancoComEnter(this);
                FormUtil.HabilitarCampos(this, false);
                BtnNovo.Enabled = true; // Habilita o botão Novo
                FormatarGrid();

                //Associa o ID da empresa a cada checkbox
                ChkEmpresa1.Tag = 1;
                ChkEmpresa2.Tag = 2;
                ChkEmpresa3.Tag = 3;
                ChkEmpresa4.Tag = 4;
                ChkEmpresa5.Tag = 5;
                ChkEmpresa2.Tag = 6;
                ChkEmpresa7.Tag = 7;
                ChkEmpresa6.Tag = 8;
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {                        
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this);
            FormUtil.AplicarPermissoes(this);
            BtnNovo.Enabled = false; // Desabilita o botão Novo

            DgvUsuarios.ClearSelection();
            DgvUsuarios.CurrentCell = null;
            idSelecionado = null; // Limpa a seleção do ID
            CmbNome.Focus(); // Foca no campo Empresa para iniciar o preenchimento

        }
       
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (idSelecionado == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            idSelecionado = Convert.ToInt32(DgvUsuarios.CurrentRow.Cells["id"].Value);

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o usuário selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                var campos = new Dictionary<string, object>
                {
                    { "deletado", 1 }
                };
                BancoUtil.AtualizarRegistro("usuarios", campos, "id", idSelecionado);

                BancoUtil.ExecutarConsulta
                (
                    tabela: "usuarios",
                    grid: DgvUsuarios,
                    colunas: "id, nome, usuario, acesso, empresas",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "id ASC, nome ASC"
                );

                FormUtil.FormatarCodigo(DgvUsuarios);
                MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormUtil.LimparCampos(this);
            }
        }       
        private void FormatarGrid()
        {
            var configuracoesEmpresas = new Dictionary<string, (string Titulo, int largura, bool Visible)>
            {
                { "id", ("Codigo", 70, true) },
                { "nome", ("Nome", 200, true) },
                { "usuario", ("Usuário", 150, true) },
                { "acesso", ("Acesso", 100, true) },
                { "empresas", ("Empresas", 300, true) }
            };

            FormUtil.FormatarGridGenerico(DgvUsuarios, configuracoesEmpresas);
            FormUtil.FormatarCodigo(DgvUsuarios, "id");
            DgvUsuarios.RowHeadersVisible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = true; // Habilita o botão Novo
            FormUtil.AplicarPermissoes(this);
            
        }

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvUsuarios.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = DgvUsuarios.Rows[e.RowIndex];

                
                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);
                CmbNome.Text = row.Cells["nome"].Value.ToString();
                TxtUsuario.Text = row.Cells["usuario"].Value.ToString();
                CmbAcesso.Text = row.Cells["acesso"].Value.ToString();
                //TxtSenha.Text = ""; // Limpa o campo de senha para segurança

                FormUtil.HabilitarCampos(this);
                FormUtil.AplicarPermissoes(this);

            }
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}





    
