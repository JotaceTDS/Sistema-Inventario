using Inventario.Classes;
using MySql.Data.MySqlClient;
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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using static Inventario.Classes.BancoUtil;

namespace Inventario.Formularios
{
    public partial class FrmEstoque : Form
    {
        private int? idSelecionado = null;
        private readonly ToolTip tooltipObservacao = new ToolTip();

        public FrmEstoque()
        {
            InitializeComponent();
            // Vincula o evento de mouse
            //DgvEstoque.CellMouseEnter += DgvEstoque_CellMouseEnter;
        }
        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            TxtValPro.Text = "0,00";            
            BancoUtil.ExecutarConsulta
            (
                tabela: "estoque",
                grid: DgvEstoque,
                colunas: "id, empresa, descricao, patrimonio, local, setor, usuario, marca, modelo, hostname, nf, fornecedor, vl_prod, dt_entrada, serie, tag, lic_windows, lic_office, Observacao",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, descricao ASC, patrimonio ASC, id ASC"                         
            );
            DgvEstoque.ClearSelection();
            FormUtil.FormatarCodigo(DgvEstoque);
            BancoUtil.CarregarCombo(CmbEmpresa, "empresa", "id", "fantasia", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(CmbPesqEmpre, "empresa", "fantasia", "fantasia", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(CmbUser, "funcionarios", "id", "nome", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(CmbDesc, "produto", "descricao", "descricao", usarDistinct: true, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(CmbMarca, "produto", "marca", "marca", usarDistinct: true, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(CmbModelo, "produto", "id", "modelo", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(CmbFornece, "fornecedor", "id", "fantasia", usarDistinct: false, incluirEmBranco: true, textoEmBranco: "");
            BancoUtil.CarregarCombo(CmbSetor, "departamentos","id", "descricao", usarDistinct: true, incluirEmBranco: true, textoEmBranco: "");

            FormUtil.AplicarAvancoComEnter(this);
            DgvEstoque.CellFormatting += DgvEstoque_CellFormatting;
            DgvEstoque.CellToolTipTextNeeded += DgvEstoque_CellToolTipTextNeeded;
            TxtPesqNome.TextChanged += TxtPesqNome_TextChanged;
            FormUtil.CarregarUFs(CmbLocal);
            FormUtil.HabilitarCampos(this, false);
            FormatarGrid();
            GridUtil.DestacarDuplicados(DgvEstoque, "empresa", "patrimonio");
            BancoUtil.DestacarObservacoes(DgvEstoque, "observacao");            
                        
            BtnNovo.Enabled = SessaoUsuario.EhAdmin;
            CmbPesqEmpre.Enabled = true;
            CmbPesqCamp.Enabled = true;
            TxtPesqNome.Enabled = true;
            BtnFiltrar.Enabled = true;
            BtnCancelFiltro.Enabled = true;
           
            RbtNf.Enabled = false;
            RbtTermo.Enabled = false;

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, true);
            
            CmbEmpresa.Focus();
            DgvEstoque.ClearSelection();
            DgvEstoque.CurrentCell = null;
            idSelecionado = null; // Limpa a seleção do ID            
            TxtValPro.Text = "0,00"; // Reseta o valor do produto para 0,00

            CmbPesqEmpre.Enabled = false;
            CmbPesqCamp.Enabled = false;
            TxtPesqNome.Enabled = false;

            BtnNovo.Enabled = false;
            BtnFiltrar.Enabled = false;
            BtnCancelFiltro.Enabled = false;
            
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
             
            RbtTermo.Enabled = false;
            RbtNf.Enabled = false;
            CmbPesqCamp.Enabled = true;
            CmbPesqEmpre.Enabled = true;
            TxtPesqNome.Enabled = true;
            BtnFiltrar.Enabled = true;
            BtnCancelFiltro.Enabled = true;
            BtnNovo.Enabled = true;

            idSelecionado = null; // Limpa a seleção do ID
            TxtValPro.Text = "0,00"; // Reseta o valor do produto para 0,00

        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorio())
                return;

            string valorTexto = TxtValPro.Text.Replace("R$", "").Trim();

            if (!decimal.TryParse(valorTexto, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal valorDecimal))
            {
                MessageBox.Show("Valor do produto inválido. Por favor, insira um valor válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string empresa = CmbEmpresa.Text.Trim().ToUpper();
            string patrimonio = TxtPatrimonio.Text.Trim();

            var campos = new Dictionary<string, object>
            {
                { "empresa", CmbEmpresa.Text },
                { "patrimonio", TxtPatrimonio.Text },
                { "local", CmbLocal.Text },
                { "setor", CmbSetor.Text },
                { "usuario", CmbUser.Text },
                { "hostname", TxtHostname.Text },
                { "nf", TxtNF.Text },
                { "descricao", CmbDesc.Text },
                { "marca", CmbMarca.Text },
                { "modelo", CmbModelo.Text },
                { "lic_windows", CmbLwin.Text },
                { "vl_prod", valorDecimal },
                {"dt_entrada", BancoUtil.ConverterDataBanco(TxtAquisicao.Text) },
                { "serie", TxtSerie.Text },
                { "fornecedor", CmbFornece.Text },
                { "tag", TxtTag.Text },
                { "lic_office", CmbLoffice.Text },
            };

            if (decimal.TryParse(TxtValPro.Text, NumberStyles.Currency, new CultureInfo("pt-BR"), out decimal valorProduto))
            {
                campos["vl_prod"] = valorProduto;
            }
            else
            {
                MessageBox.Show("Valor do produto invalido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (idSelecionado == null)
            {
                bool patrimonioExiste = BancoUtil.RegistroExiste("estoque", new Dictionary<string, object>
                {
                    { "empresa", empresa },
                    { "patrimonio", patrimonio }
                });
                if (patrimonioExiste)
                {
                    MessageBox.Show("Já existe um registro com este patrimônio para a empresa selecionada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                BancoUtil.InserirRegistro("estoque", campos);
                MessageBox.Show("Registro inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool patrimonioExiste = BancoUtil.EditarSemDuplicidade("estoque", new Dictionary<string, object>
                {
                    { "empresa", empresa },
                    { "patrimonio", patrimonio },
                },
                "id", idSelecionado.Value
                );
                BancoUtil.AtualizarRegistro("estoque", campos, "id", idSelecionado.Value);
                MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string usuario = CmbUser.Text.Trim();

            if (!string.IsNullOrEmpty(usuario))
            {
                DialogResult gerarTermo = MessageBox.Show("Deseja gerar o termo de responsabilidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (gerarTermo == DialogResult.Yes)
                {
                    if (idSelecionado == null)
                    {
                        MessageBox.Show("Selecione um item no inventário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string pastaTermos = Path.Combine(Application.StartupPath, "Termos");
                    //string nomeEmpresa = cmbEmpresa.Text.Trim().ToUpper();
                    string nomeEmpresa = CmbEmpresa.Text.Trim();
                    string nomeArquivoModelo = null;

                    switch (nomeEmpresa)
                    {

                        case "Ocktus Matriz":
                            nomeArquivoModelo = "Termo_Epitychia.docx";
                            break;
                        case "Ocktus Filial":
                            nomeArquivoModelo = "Termo_Epitychia.docx";
                            break;
                        case "Instituto Exito":
                            nomeArquivoModelo = "Termo_Exito.docx";
                            break;
                        case "Temmus Educacao":
                            nomeArquivoModelo = "Termo_Themmus.docx";
                            break;
                        case "EA Entretenimento Matriz":
                            nomeArquivoModelo = "Termo_EA_Entretenimento.docx";
                            break;
                        case "EA Entretenimento Filial":
                            nomeArquivoModelo = "Termo_EA_Entretenimento.docx";
                            break;
                        case "JD Business Academy":
                            nomeArquivoModelo = "Termo_JD_Business.docx";
                            break;
                        default:
                            MessageBox.Show("Empresa não definida para geração de termo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }
                    if (nomeArquivoModelo == null)
                    {
                        MessageBox.Show("Empresa sem modelo de termo definido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string caminhoModelo = Path.Combine(pastaTermos, nomeArquivoModelo);

                    if (!File.Exists(caminhoModelo))
                    {
                        MessageBox.Show($"Modelo de termo não encontrado: {caminhoModelo}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        BancoUtil.GerarTermoPreenchido(idSelecionado.Value, caminhoModelo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gerar o termo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
            BancoUtil.ExecutarConsulta(
                tabela: "estoque",
                grid: DgvEstoque,
                colunas: "id, empresa, patrimonio, local, setor, usuario, descricao, marca, modelo, hostname, nf, fornecedor, vl_prod, dt_entrada, serie, tag, lic_windows, lic_office, Observacao",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, patrimonio ASC, descricao ASC"
            );

            DgvEstoque.ClearSelection();
            FormUtil.FormatarCodigo(DgvEstoque);
            FormUtil.LimparCampos(this);
            FormUtil.HabilitarCampos(this, false);
            BtnNovo.Enabled = true;
            BtnFiltrar.Enabled = true;
            CmbPesqCamp.Enabled = true;
            TxtPesqNome.Enabled = true;

            FormatarGrid();
            GridUtil.DestacarDuplicados(DgvEstoque, "empresa", "patrimonio");
            BancoUtil.DestacarObservacoes(DgvEstoque, "observacao");
        }
       
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            idSelecionado = Convert.ToInt32(DgvEstoque.SelectedRows[0].Cells["id"].Value);

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var campos = new Dictionary<string, object>
                {
                    { "deletado", false }
                };
                BancoUtil.AtualizarRegistro("estoque", campos, "id", idSelecionado);
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                
                BancoUtil.ExecutarConsulta(
                    tabela: "estoque",
                    grid: DgvEstoque,
                    colunas: "id, empresa, patrimonio, local, setor, usuario, descricao, marca, modelo, hostname, nf, fornecedor, vl_prod, dt_entrada, serie, tag, lic_windows, lic_office, Observacao",
                    filtrosObrigatorios: null,
                    filtrosOpcionais: null,
                    orderBy: "empresa ASC, patrimonio ASC, descricao ASC"
                );
                DgvEstoque.ClearSelection();
                FormUtil.FormatarCodigo(DgvEstoque);
                FormUtil.AplicarAvancoComEnter(this);
                FormatarGrid();
                GridUtil.DestacarDuplicados(DgvEstoque, "empresa", "patrimonio");
                BancoUtil.DestacarObservacoes(DgvEstoque, "observacao");
                FormUtil.LimparCampos(this);
                FormUtil.HabilitarCampos(this, false);
            }
        }
        private void FormatarGrid()
        {
            if (DgvEstoque.Columns.Count == 0)
                return;
            try
            {
                var configuracoesEmpresas = new Dictionary<string, (string Titulo, int Largura, bool Visivel)>
                {
                    { "id", ("Código", 50, false) }, // Essa será ocultada
                    { "empresa", ("Empresa", 130, true) },
                    { "patrimonio", ("Patrimônio", 59, true) },
                    { "local", ("Local", 40, true) },
                    { "setor", ("Departamento", 100, true) },
                    { "usuario", ("Usuário", 180, true) },
                    { "nf", ("Nota Fiscal", 90, true) },
                    { "descricao", ("Descrição", 150, true) },
                    { "marca", ("Marca", 80, true) },
                    { "modelo", ("Modelo", 150, true) },
                    { "vl_prod", ("Valor Produto", 100, true) },
                    { "dt_entrada", ("Entrada", 65, true) },
                    { "serie", ("Série", 80, true) },
                    { "fornecedor", ("Fornecedor", 100, true) },
                    { "tag", ("Tag", 100, true) },
                    { "hostname", ("Host Name", 110, true) },
                    { "lic_windows", ("Licença Windows", 120, true) },
                    { "lic_office", ("Licença Office", 110, true) },
                    { "observacao", ("Observação", 10, false) }
                };                
                FormUtil.FormatarGridGenerico(DgvEstoque, configuracoesEmpresas);
                FormUtil.FormatarCodigo(DgvEstoque, "id");
                DgvEstoque.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao formatar o grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                   
        private bool CampoObrigatorio()
        {
            if (string.IsNullOrWhiteSpace(CmbEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtPatrimonio.Text) ||
                string.IsNullOrWhiteSpace(CmbLocal.Text) ||
                string.IsNullOrWhiteSpace(CmbDesc.Text) ||
                string.IsNullOrWhiteSpace(CmbMarca.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void DgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormUtil.HabilitarCampos(this, false);
            
            CmbPesqEmpre.Enabled = true;
            CmbPesqCamp.Enabled = true;
            TxtPesqNome.Enabled = true;
            BtnFiltrar.Enabled = true;
            BtnCancelFiltro.Enabled = true;

            BtnNovo.Enabled = true;           
            //idSelecionado = null; // Limpa a seleção do ID
            //FormUtil.LimparCampos(this);

            //TxtValPro.Text = "0,00"; // Reseta o valor do produto para 0,00

        }
        private void DgvEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DgvEstoque.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = DgvEstoque.Rows[e.RowIndex];

                idSelecionado = Convert.ToInt32(row.Cells["id"].Value);

                CmbEmpresa.Text = row.Cells["empresa"].Value.ToString();
                TxtPatrimonio.Text = row.Cells["patrimonio"].Value.ToString();
                CmbLocal.Text = row.Cells["local"].Value.ToString();
                CmbSetor.Text = row.Cells["setor"].Value.ToString();
                CmbUser.Text = row.Cells["usuario"].Value.ToString();
                TxtHostname.Text = row.Cells["hostname"].Value.ToString();
                TxtNF.Text = row.Cells["nf"].Value.ToString();
                CmbDesc.Text = row.Cells["descricao"].Value.ToString();
                CmbMarca.Text = row.Cells["marca"].Value.ToString();
                CmbModelo.Text = row.Cells["modelo"].Value.ToString();
                CmbLwin.Text = row.Cells["lic_windows"].Value.ToString();
                TxtValPro.Text = FormUtil.FormatarMoeda(row.Cells["vl_prod"].Value?.ToString());
                TxtAquisicao.Text = FormUtil.RemoverMascara(row.Cells["dt_entrada"].Value.ToString());
                TxtSerie.Text = row.Cells["serie"].Value.ToString();
                CmbFornece.Text = row.Cells["fornecedor"].Value.ToString();
                TxtTag.Text = row.Cells["tag"].Value.ToString();
                CmbLoffice.Text = row.Cells["lic_office"].Value.ToString();
                FormUtil.HabilitarCampos(this, true);
                
                RbtNf.Checked = true;
                RbtNf.Enabled = true;
                RbtTermo.Enabled = true;
                BtnNovo.Enabled = false;

            }
        }

        private void DgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvEstoque.Columns[e.ColumnIndex].Name == "vl_prod" && e.Value != null)
            {
                e.Value = FormUtil.FormatarMoeda(e.Value.ToString());
                e.FormattingApplied = true;
            }

        }
        private void BtnFiltrar_Click(object sender, EventArgs e)
        {

            var filtrosObrigatorios = new Dictionary<string, object>();
            
            string empresa = CmbPesqEmpre.Text.Trim();
           
            if (!string.IsNullOrWhiteSpace(empresa))            
                filtrosObrigatorios.Add("empresa", empresa);
            

            var filtrosOpcionais = new Dictionary<string, string>();

            string campoOpcional = CmbPesqCamp.Text.Trim();
            string textoOpcional = TxtPesqNome.Text.Trim();

            if (!string.IsNullOrEmpty(campoOpcional))
            {
                if (string.IsNullOrEmpty(textoOpcional))
                {
                    // queremos registros com campo em branco (NULL ou '')
                    filtrosOpcionais.Add(campoOpcional, "__IS_BLANK__");
                }
                else if (campoOpcional.Equals("dt_entrada", StringComparison.OrdinalIgnoreCase))
                {
                    // validar data dd/MM/aaaa para não mandar lixo pro banco
                    if (!DateTime.TryParseExact(textoOpcional, "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out _))
                    {
                        MessageBox.Show("Data inválida. Use o formato dd/MM/aaaa.", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    filtrosOpcionais.Add(campoOpcional, textoOpcional);
                }
                else
                {
                    // demais campos: LIKE %texto%
                    filtrosOpcionais.Add(campoOpcional, textoOpcional);
                }
            }
            
            BancoUtil.ExecutarConsulta(
                tabela: "estoque",
                grid: DgvEstoque,
                colunas: "id, empresa, patrimonio, local, setor, usuario, nf, descricao, marca, modelo, vl_prod, dt_entrada, serie, fornecedor, tag, hostname, lic_windows, lic_office, observacao",
                filtrosObrigatorios: filtrosObrigatorios,
                filtrosOpcionais: filtrosOpcionais,
                orderBy: "descricao ASC, patrimonio ASC"
                );

            BancoUtil.DestacarObservacoes(DgvEstoque, "observacao");


        }
        private void BtnCancelFiltro_Click(object sender, EventArgs e)
        {
            BancoUtil.ExecutarConsulta
            (
                tabela: "estoque",
                grid: DgvEstoque,
                colunas: "id, empresa, patrimonio, local, setor, usuario, descricao, marca, modelo, hostname, nf, fornecedor, vl_prod, dt_entrada, serie, tag, lic_windows, lic_office, Observacao",
                filtrosObrigatorios: null,
                filtrosOpcionais: null,
                orderBy: "empresa ASC, patrimonio ASC, descricao ASC"
            );

            DgvEstoque.ClearSelection();
            FormUtil.FormatarCodigo(DgvEstoque);
            DgvEstoque.CellFormatting += DgvEstoque_CellFormatting;
            FormatarGrid();
            GridUtil.DestacarDuplicados(DgvEstoque, "empresa", "patrimonio");
        }

        private void TxtPesqNome_TextChanged(object sender, EventArgs e)
        {
            // filtros obrigatórios (empresa só se for escolhida)
            var filtrosObrigatorios = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(CmbPesqEmpre.Text))
                filtrosObrigatorios["empresa"] = CmbPesqEmpre.Text.Trim();

            // filtros opcionais
            var filtrosOpcionais = new Dictionary<string, string>();
            string campoOpcional = CmbPesqCamp.Text?.Trim();
            string textoOpcional = TxtPesqNome.Text?.Trim();

            if (!string.IsNullOrEmpty(campoOpcional))
            {
                if (string.IsNullOrEmpty(textoOpcional))
                {
                    // buscar registros em branco
                    filtrosOpcionais[campoOpcional] = "__IS_BLANK__";
                }
                else if (campoOpcional.Equals("dt_entrada", StringComparison.OrdinalIgnoreCase))
                {
                    // validar formato de data
                    if (!DateTime.TryParseExact(
                            textoOpcional,
                            "dd/MM/yyyy",
                            new CultureInfo("pt-BR"),
                            DateTimeStyles.None,
                            out _))
                    {
                        return; // se for data inválida, não pesquisa
                    }
                    filtrosOpcionais[campoOpcional] = textoOpcional;
                }
                else
                {
                    // LIKE para qualquer outro campo (inclui CPF, nome, etc.)
                    filtrosOpcionais[campoOpcional] = $"%{textoOpcional}%";
                }
            }

            // executa a consulta
            BancoUtil.ExecutarConsulta(
               tabela: "estoque",
               grid: DgvEstoque,
               colunas: "id, empresa, patrimonio, local, setor, usuario, nf, descricao, marca, modelo, vl_prod, dt_entrada, serie, fornecedor, tag, hostname, lic_windows, lic_office, observacao",
               filtrosObrigatorios: filtrosObrigatorios,
               filtrosOpcionais: filtrosOpcionais,
               orderBy: "empresa ASC, patrimonio ASC, descricao ASC"
            );
            BancoUtil.DestacarObservacoes(DgvEstoque, "observacao");
        }

        private void CmbPesqCamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPesqCamp.Text.Trim().Equals("Data entrada", StringComparison.OrdinalIgnoreCase) ||
                CmbPesqCamp.Text.Trim().Equals("Entrada", StringComparison.OrdinalIgnoreCase))
            {
                // Máscara para data no formato dd/MM/yyyy
                TxtPesqNome.Mask = "00/00/0000";
                TxtPesqNome.ValidatingType = typeof(DateTime);
                TxtPesqNome.Focus();
                
            }
            else
            {
                TxtPesqNome.Mask = ""; // remove máscara
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
        private void BtnVisualiza_Click(object sender, EventArgs e)
        {
            try
            {
                // Caminho fixo da VM (servidor de arquivos)
                string servidor = @"\\172.16.250.4\Sistema";

                string pastaBase;
                string empresa = (CmbEmpresa.Text ?? "").Trim();
                string chave;

                if (RbtNf.Checked)
                {
                    pastaBase = Path.Combine(servidor, "NF", "Empresa", empresa);
                    chave = (TxtNF.Text ?? "").Trim();
                }
                else if (RbtTermo.Checked)
                {
                    pastaBase = Path.Combine(servidor, "Termo", "Empresa", empresa);
                    chave = (TxtPatrimonio.Text ?? "").Trim();
                }
                else
                {
                    MessageBox.Show("Selecione Nota Fiscal ou Termo para visualizar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrWhiteSpace(chave))
                {
                    MessageBox.Show("Informe o número da NF ou o patrimônio.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Directory.Exists(pastaBase))
                {
                    MessageBox.Show("Pasta não acessível: " + pastaBase + "\nVerifique a rede/permissões.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string chaveSan = Regex.Replace(chave, @"[^0-9A-Za-zÁ-Úá-úÃ-Õã-õÇç \\-_]", "");
                string caminhoExato = Path.Combine(pastaBase, chaveSan + ".pdf");

                if (File.Exists(caminhoExato))
                {
                    AbrirNoAppPadrao(caminhoExato);
                    return;
                }

                var candidatos = Directory.EnumerateFiles(pastaBase, "*" + chaveSan + "*.pdf", SearchOption.AllDirectories)
                                          .Distinct()
                                          .ToList();

                if (candidatos.Count == 0)
                {
                    MessageBox.Show("Documento não encontrado para: " + chave, "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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
                MessageBox.Show("Erro ao abrir o documento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnAnexar_Click(object sender, EventArgs e)
        {
            try
            {
                //string servidor = @"\\SERVIDOR-BD\sistema";
                string servidor = Conexao.CaminhoSistema;
                string caminhoNF = Path.Combine(servidor, "NF");

                string empresa = (CmbEmpresa.Text ?? "").Trim();

                // 1) pega o número da NF
                var numeroNF = (TxtNF.Text ?? "").Trim();

                if (string.IsNullOrWhiteSpace(numeroNF))
                {
                    MessageBox.Show("Informe o número da Nota Fiscal (Nota Fiscal) antes de anexar.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtNF.Focus();
                    return;
                }

                // 2) sanitiza pra nome de arquivo
                var numeroSan = Regex.Replace(numeroNF, @"[^0-9A-Za-zÁ-Úá-úÃ-Õã-õÇç\-_ ]", "");

                // 3) escolhe o arquivo local (PDF)
                using (var ofd = new OpenFileDialog())
                {
                    ofd.Title = "Selecione o PDF da Nota Fiscal";
                    ofd.Filter = "PDF (*.pdf)|*.pdf|Todos os arquivos (*.*)|*.*";
                    ofd.Multiselect = false;

                    if (ofd.ShowDialog() != DialogResult.OK)
                        return;

                    var origem = ofd.FileName;
                    if (!File.Exists(origem))
                    {
                        MessageBox.Show("Arquivo selecionado não existe.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 4) monta destino no servidor                                                            
                    var pastaServidor = Path.Combine(servidor, "NF", "Empresa", empresa);

                    if (!Directory.Exists(pastaServidor))
                    {
                        // tenta criar (se o usuário tiver permissão)
                        try
                        {
                            Directory.CreateDirectory(pastaServidor);
                        }
                        catch { /* ignora */ }
                    }

                    if (!Directory.Exists(pastaServidor))
                    {
                        MessageBox.Show("Não foi possível acessar/criar a pasta no servidor:\n" + pastaServidor,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var destino = Path.Combine(pastaServidor, numeroSan + ".pdf");

                    // 5) se existir, pergunta se deseja substituir
                    if (File.Exists(destino))
                    {
                        var resp = MessageBox.Show(
                            "Já existe uma NF com esse número no servidor.\nDeseja substituir?",
                            "Arquivo existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resp != DialogResult.Yes)
                            return;

                        try
                        {
                            File.Delete(destino);
                        }
                        catch { /* se não conseguir, o Copy abaixo vai falhar e avisar */ }
                    }

                    // 6) copia (renomeando) para o servidor
                    File.Copy(origem, destino, true);

                    MessageBox.Show("Nota Fiscal anexada com sucesso!\n" + destino, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormUtil.HabilitarCampos(this, false);

                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Sem permissão para gravar na pasta de NF do servidor.", "Permissão",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Erro de E/S ao salvar o arquivo: " + ioEx.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao anexar a Nota Fiscal: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnObservacao_Click(object sender, EventArgs e)
        {
            if (DgvEstoque.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(DgvEstoque.CurrentRow.Cells["id"].Value);
            string obsAtual = DgvEstoque.CurrentRow.Cells["observacao"].Value?.ToString() ?? "";

            using (var frm = new FrmObservacao(obsAtual))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string novaObs = frm.Observacao;

                    // Atualiza no banco
                    BancoUtil.AtualizarRegistro("estoque", new Dictionary<string, object>{ { "observacao", novaObs } }, "id", id);

                    // Atualiza no grid
                    DgvEstoque.CurrentRow.Cells["observacao"].Value = novaObs;

                    //// Destaca a linha em amarelo
                    //dgvEstoque.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;

                    //// Tooltip
                    //dgvEstoque.CurrentRow.Cells["observacao"].ToolTipText = novaObs;

                    if (string.IsNullOrWhiteSpace(novaObs))
                    {
                        DgvEstoque.CurrentRow.DefaultCellStyle.BackColor = DgvEstoque.DefaultCellStyle.BackColor; // cor padrão
                        DgvEstoque.CurrentRow.Cells["observacao"].ToolTipText = null;
                    }
                    else
                    {
                        DgvEstoque.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                        DgvEstoque.CurrentRow.Cells["observacao"].ToolTipText = novaObs;
                    }

                    // Limpa seleção e ID
                    DgvEstoque.ClearSelection();
                    idSelecionado = null;

                    MessageBox.Show("Observação adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DgvEstoque_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var row = DgvEstoque.Rows[e.RowIndex];

            if (row.DefaultCellStyle.BackColor == Color.Yellow)
            {
                string obs = row.Cells["observacao"].Value?.ToString() ?? "";
                e.ToolTipText = obs;
            }
            else
            {
                e.ToolTipText = null;
            }
        }

        private void DgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }

}


