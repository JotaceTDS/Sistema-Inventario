using Inventario.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.IO;    
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventario.Formularios
{
    public partial class FrmServicosTi : Form
    {
        private int? idSelecionado = null;
        public FrmServicosTi()
        {
            InitializeComponent();
            DgvServicos.CellFormatting += DgvServicos_CellFormatting;

        }

        private void FrmServicosTi_Load(object sender, EventArgs e)
        {
            TxtValor.Text = "0,00";
            
            BancoUtil.ExecutarConsulta
            (
                tabela: "servicos",
                grid: DgvServicos,
                colunas: "id, empresa, fornecedor, contato, telefone, servico, link, vencimento, valor, usuario, senha_hash, contrato",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, fornecedor ASC"
            );
                
            DgvServicos.ClearSelection();
            BancoUtil.CarregarCombo(CmbEmpresa, "empresa", "id", "fantasia");
            BancoUtil.CarregarCombo(CmbFornecedor, "fornecedor", "id", "fantasia");
            BancoUtil.CarregarCombo(CmbFiltrar, "empresa", "id", "fantasia");
            FormUtil.AplicarAvancoComEnter(this);
            DgvServicos.CellFormatting += DgvServicos_CellFormatting;
            FormatarGrid();
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
        }
        
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this);
            CmbEmpresa.Focus();
            DgvServicos.ClearSelection();
            DgvServicos.CurrentCell = null;
            idSelecionado = null;
            TxtValor.Text = "0,00";

            CmbFiltrar.Enabled = false;
            BtnFiltrar.Enabled = false;
            RdbFornecedor.Enabled = false;
            RdbServico.Enabled = false;
            BtnNovo.Enabled = false;

        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CamposObrigatorio())
            {
                return;
            }

            string valorTexto = TxtValor.Text.Replace("R$", "").Trim();
                   
            var filtroDuplicidade = new Dictionary<string, object>
            {
                {"empresa", CmbEmpresa.Text },
                {"servico", TxtServico.Text },
                {"usuario", TxtUsuario.Text },
                {"senha_hash", TxtSenha.Text }
            };

            if (idSelecionado == null && BancoUtil.RegistroExiste("servicos", filtroDuplicidade))
            {
                MessageBox.Show("Já existe um serviço com esses dados cadastrados para esta empresa.", "Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(valorTexto, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorDecimal))
            {
                MessageBox.Show("Valor inválido. Por favor, insira um valor numérico válido.", "Erro de Valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtValor.Focus();
                return;
            }
            
            string valorFormatado = valorDecimal.ToString(CultureInfo.InvariantCulture);


            var campos = new Dictionary<string, object>
            {
                {"empresa", CmbEmpresa.Text },
                {"fornecedor", CmbFornecedor.Text },
                {"contato", TxtContato.Text },
                {"telefone", TxtTelefone.Text },
                {"servico", TxtServico.Text },
                {"link", TxtLink.Text},
                {"vencimento", BancoUtil.ConverterDataBanco(TxtFimContrato.Text) },
                {"valor", valorFormatado },
                {"usuario", TxtUsuario.Text },
                {"senha_hash", TxtSenha.Text },
                {"contrato", TxtContrato.Text }
            };

            
            if (idSelecionado == null)
            {
                BancoUtil.InserirRegistro("servicos", campos);
                MessageBox.Show("Registro salvo com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BancoUtil.AtualizarRegistro("servicos", campos, "id", idSelecionado);
                MessageBox.Show("Registro atualizado com sucesso...!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BancoUtil.ExecutarConsulta
            (
                tabela: "servicos",
                grid: DgvServicos,
                colunas: "id, empresa, fornecedor, contato, telefone, servico, link, vencimento, valor, usuario, senha_hash, contrato",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, fornecedor ASC"
            );

            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            FormatarGrid();
            CmbFiltrar.Enabled = true;
            BtnFiltrar.Enabled = true;
            RdbFornecedor.Enabled = true;
            RdbServico.Enabled = true;
            BtnNovo.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            
            CmbFiltrar.Enabled = true;
            BtnFiltrar.Enabled = true;
            RdbFornecedor.Enabled = true;
            RdbServico.Enabled = true;
            BtnNovo.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvServicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            idSelecionado = Convert.ToInt32(DgvServicos.SelectedRows[0].Cells["id"].Value);

            DialogResult resposta = MessageBox.Show("Deseja excluir o registro selecionado ?", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                var campos = new Dictionary<string, object>
                {
                   {"deletado", 1 }
                };
                BancoUtil.AtualizarRegistro("servicos", campos, "id", idSelecionado);
                BancoUtil.ExecutarConsulta
            (
                tabela: "servicos",
                grid: DgvServicos,
                colunas: "id, empresa, fornecedor, contato, telefone, servico, link, vencimento, valor, usuario, senha_hash, contrato",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, fornecedor ASC"
            );
                FormatarGrid();
                FormUtil.HabilitarCampos(this, false);
                BtnNovo.Enabled = true;
                CmbFiltrar.Enabled = true;
                BtnFiltrar.Enabled = true;
                RdbFornecedor.Enabled = true;
                RdbServico.Enabled = true;

            }

        }
        private bool CamposObrigatorio()
        {
            if (string.IsNullOrWhiteSpace(CmbEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtServico.Text))

            {
                MessageBox.Show("Prencha todos os campos obrigatorios...!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (!string.IsNullOrWhiteSpace(TxtContato.Text.Trim()) &&
                !DateTime.TryParse(TxtFimContrato.Text, out _))

            {
                MessageBox.Show("Data de vencimento invalida!", "Erro de Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtFimContrato.Focus();
                return false;
            }

            return true;
        }

        private void FormatarGrid()
        {
            if (DgvServicos.Columns.Count == 0)
                return;
            try
            {
                var configuracoesEmpresas = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
                {
                    { "id", ("Codigo", 50, true) },
                    { "empresa", ("Empresa", 140, true) },
                    { "fornecedor", ("Fornecedor", 140, true) },
                    { "contato", ("Contato", 80, true) },
                    { "telefone", ("Telefone", 100, true) },
                    { "servico", ("Serviço", 150, true) },
                    { "link", ("Link", 180, true) },
                    { "vencimento", ("Vencimento", 80, true) },
                    { "valor", ("Valor", 80, true) },
                    { "usuario", ("Usuário", 150, true) },
                    { "senha_hash", ("Senha", 80, true) },
                    { "contrato", ("Contrato", 80, true) }
                };
                FormUtil.FormatarGridGenerico(DgvServicos, configuracoesEmpresas);
                FormUtil.FormatarCodigo(DgvServicos, "id");
                DgvServicos.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao formatar o grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                 
        private void DgvServicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvServicos.Columns[e.ColumnIndex].Name == "senha_hash" && e.Value != null)
            {
                // Exibe asteriscos no lugar da senha
                e.Value = new string('*', 8); // Exibe sempre 8 asteriscos, independente do tamanho da senha
                e.FormattingApplied = true;
            }

            if (DgvServicos.Columns[e.ColumnIndex].Name == "valor" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal valorDecimal))
                {
                    e.Value = valorDecimal.ToString("C2"); // Formata como moeda com 2 casas decimais
                    e.FormattingApplied = true;
                }
            }
        }

        private void DgvServicos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnVerSenha.Enabled = true; // Torna o botão de ver senha visível ao clicar duas vezes na linha
            BtnVerContrato.Enabled = true; // Habilita o botão de visualizar contrato

            if (DgvServicos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para editar...!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex >= 0 && DgvServicos.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = DgvServicos.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);
                CmbEmpresa.   Text = row.Cells["empresa"].Value.ToString();
                CmbFornecedor.Text = row.Cells["Fornecedor"].Value.ToString();
                TxtContato.Text = row.Cells["contato"].Value.ToString();
                TxtTelefone.Text = row.Cells["telefone"].Value.ToString();
                TxtServico.Text = row.Cells["servico"].Value.ToString();
                TxtLink.Text = row.Cells["link"].Value.ToString();
                TxtFimContrato.Text = row.Cells["vencimento"].Value.ToString();
                TxtValor.Text = FormUtil.FormatarMoeda(row.Cells["valor"].Value.ToString());
                TxtUsuario.Text = row.Cells["usuario"].Value.ToString();                
                TxtSenha.Tag = row.Cells["senha_hash"].Value.ToString();                
                TxtSenha.Text = "********";
                TxtContrato.Text = row.Cells["contrato"].Value.ToString(); 
            }
            FormUtil.HabilitarCampos(this, true);
            BtnNovo.Enabled = false;


        }

        private void BtnVerSenha_Click(object sender, EventArgs e)
        {
            if (TxtSenha.Text == "********")
            {
                TxtSenha.Text = TxtSenha.Tag?.ToString(); // Revela a senha real
                BtnVerSenha.Text = "Ocultar Senha"; // Altere o texto do botão
            }
            else
            {
                TxtSenha.Text = "********"; // Oculta novamente
                BtnVerSenha.Text = "Ver Senha";
            }
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // monta filtros obrigatórios (empresa só se estiver preenchida)
            var filtrosObrigatorios = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(CmbFiltrar.Text))            
                filtrosObrigatorios["empresa"]= CmbFiltrar.Text.Trim();

            // monta filtros opcionais 
            var filtrosOpcionais = new Dictionary<string, object>();

            string texto = TxtPesquisa.Text.Trim();
            string campo = "";

            if (RdbFornecedor.Checked) campo = "fornecedor";
            else if (RdbServico.Checked) campo = "servico";
            
            if (!string.IsNullOrWhiteSpace(campo) && !string.IsNullOrWhiteSpace(texto))
            {
                if (campo == "fornecedor")
                {
                    filtrosOpcionais[campo] = $"%{texto}%"; // Usa LIKE para esses campos
                }
                else if (campo == "servico")
                {
                    filtrosOpcionais[campo] = $"%{texto}%"; // Usa LIKE para esses campos
                }                                
            }

            if (RdbFornecedor.Checked)
            {
                campo = "fornecedor";
            }
            else if (RdbServico.Checked)
            {
                campo = "servico";
            }            
            BancoUtil.ExecutarConsulta
            (
                tabela: "servicos",
                grid: DgvServicos,
                colunas: "id, empresa, fornecedor, contato, telefone, servico, link, vencimento, valor, usuario, senha_hash, contrato",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, fornecedor ASC"
            );
        }
       

        // Nova rotina para formatar o valor como moeda
        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                try
                {
                    txt.TextChanged -= TxtValor_TextChanged; // Remove o evento para evitar loop
                    
                    // Você precisa pegar o retorno do método e jogar de volta no txt.Text
                    string textoFormatado = FormUtil.FormatarMoeda(txt.Text);

                    // Só altera se houver mudança (evita processamento desnecessário)
                    if (txt.Text != textoFormatado)
                    {
                        txt.Text = textoFormatado;
                        // Move o cursor para o final do texto
                        txt.SelectionStart = txt.Text.Length;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao formatar o valor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    txt.TextChanged += TxtValor_TextChanged; // Re-adiciona o evento
                }
            }
        }

        private void DgvServicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUtil.HabilitarCampos(this, false);
            //FormUtil.LimparCampos(this);
            BtnNovo.Enabled = true;

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            var filtosObrigatorios = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(CmbFiltrar.Text))
                filtosObrigatorios["empresa"] = CmbFiltrar.Text.Trim();

            BancoUtil.ExecutarConsulta
            (
                tabela: "servicos",
                grid: DgvServicos,
                colunas: "id, empresa, fornecedor, contato, telefone, servico, link, vencimento, valor, usuario, senha_hash, contrato",
                filtrosObrigatorios: filtosObrigatorios,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, fornecedor ASC"
            );
            BtnCancelar.Enabled = true;
        }


        private void RdbFornecedor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerContrato_Click(object sender, EventArgs e)
        {
            try
            {
                //string servidor = @"\\SERVIDOR-BD\sistema";
                string servidor = Conexao.CaminhoSistema;
                string caminhoNF = Path.Combine(servidor, "NF");


                string pastaBase = Path.Combine(servidor, "Contrato");
                string empresa = (CmbEmpresa.Text ?? "").Trim();
                string chave = TxtContato.Text.Trim();

                if (string.IsNullOrWhiteSpace(chave))
                {
                    MessageBox.Show("Não existe documento para este serviço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Directory.Exists(pastaBase))
                {
                    MessageBox.Show("Pasta não acessível: " + pastaBase + "\nVerifique a rede/permissões.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Sanitiza a chave para nome de arquivo (letras, números, espaço, - e _)
                string chaveSan = Regex.Replace(chave, @"[^0-9A-Za-zÁ-Úá-úÃ-Õã-õÇç \-_]", "");

                // 1) tenta arquivo exato <chave>.pdf na raiz da pasta
                string caminhoExato = Path.Combine(pastaBase, chaveSan + ".pdf");
                if (File.Exists(caminhoExato))
                {
                    AbrirNoAppPadrao(caminhoExato);
                    return;
                }

                // 2) busca recursiva por *<chave>*.pdf em todas as subpastas
                var candidatos = Directory.EnumerateFiles(pastaBase, "*" + chaveSan + "*.pdf", SearchOption.AllDirectories)
                                      .Distinct()
                                      .ToList();

                if (candidatos.Count == 0)
                {
                    MessageBox.Show("Documento não encontrado para: " + chave, "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Se achou vários, abre o mais recente
                string arquivoMaisRecente = candidatos.OrderByDescending(f => new FileInfo(f).LastWriteTimeUtc).First();
                AbrirNoAppPadrao(arquivoMaisRecente);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Sem permissão para acessar a pasta/arquivo.", "Permissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Erro de E/S ao acessar o arquivo: " + ioEx.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar abrir o documento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirNoAppPadrao(string caminho)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = caminho,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o arquivo: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
