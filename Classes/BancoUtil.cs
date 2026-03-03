using DocumentFormat.OpenXml.Drawing.Diagrams;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Inventario.Classes
{
    public static class BancoUtil
    {
        #region Conexão e consultas


       
        public static void ExecutarConsulta(
            string tabela,
            DataGridView grid,
            string colunas = "*",
            Dictionary<string, object> filtrosObrigatorios = null,
            Dictionary<string, string> filtrosOpcionais = null,
            string orderBy = null)
        {
            Conexao conexaoDB = new Conexao();
            MySqlConnection conn = conexaoDB.Abrir();

            if (conn == null) return;

            try
            {
                string where = "(deletado IS NULL OR deletado = '')";
                var parametros = new List<MySqlParameter>();

                // ---------------------------------------------------------
                // 🔒 Filtro automático de empresas (para usuários não admin)
                // ---------------------------------------------------------
                if (!SessaoUsuario.EhAdmin && !string.IsNullOrWhiteSpace(SessaoUsuario.Empresas))
                {
                    // 🧩 Tabelas que NÃO devem ter filtro de empresa
                    var tabelasSemFiltro = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                {
                    "cargo", "produto", "fornecedor"
                };

                    string tabelaNormalizada = (tabela ?? "").Trim().ToLower();

                    // ⚙️ Só aplica o filtro se a tabela não estiver na lista de exceções
                    if (!tabelasSemFiltro.Contains(tabelaNormalizada))
                    {
                        var empresas = SessaoUsuario.Empresas
                            .Split(',')
                            .Select(e => e.Trim())
                            .Where(e => !string.IsNullOrEmpty(e))
                            .ToList();

                        if (empresas.Any())
                        {
                            // Detecta se os valores são IDs (numéricos) ou nomes
                            bool contemNumeros = empresas.All(e => int.TryParse(e, out _));
                            string filtroEmpresas = string.Join(",", empresas.Select(e => $"'{e}'"));

                            // ⚙️ Caso especial: tabela funcionarios (campo textual)


                            // Verifica qual campo deve ser usado
                            if (tabelaNormalizada == "funcionarios")
                            {
                                where += $" AND empresa IN ({filtroEmpresas})";
                            }
                            else if (tabelaNormalizada == "empresa")
                            {
                                if (contemNumeros)
                                    where += $" AND id IN ({filtroEmpresas})";
                                else
                                    where += $" AND fantasia IN ({filtroEmpresas})";
                            }
                            else
                            {
                                // Caso padrão (usa campo empresa_id)
                                string campoEmpresa = contemNumeros ? "empresa_id" : "empresa";
                                where += $" AND {campoEmpresa} IN ({filtroEmpresas})";
                            }
                        }
                    }
                }

                // -------------------------------
                // Filtros obrigatórios
                // -------------------------------
                if (filtrosObrigatorios != null)
                {
                    foreach (var f in filtrosObrigatorios)
                    {
                        if (f.Value == null || (f.Value is string s && string.IsNullOrWhiteSpace(s))) continue;

                        if (f.Value is string sVal && sVal.Contains("%"))
                        {
                            where += $" AND `{f.Key}` LIKE @{f.Key}";
                            parametros.Add(new MySqlParameter("@" + f.Key, sVal));
                        }
                        else
                        {
                            where += $" AND `{f.Key}` = @{f.Key}";
                            parametros.Add(new MySqlParameter("@" + f.Key, f.Value));
                        }
                    }
                }

                // -------------------------------
                // Filtros opcionais
                // -------------------------------
                if (filtrosOpcionais != null)
                {
                    foreach (var fo in filtrosOpcionais)
                    {
                        if (string.IsNullOrWhiteSpace(fo.Key)) continue;
                        string val = fo.Value ?? "";

                        if (val == "__IS_BLANK__")
                        {
                            where += $" AND (`{fo.Key}` IS NULL OR TRIM(`{fo.Key}`) = '')";
                            continue;
                        }

                        if (val.Contains("%"))
                        {
                            where += $" AND `{fo.Key}` LIKE @{fo.Key}";
                        }
                        else
                        {
                            where += $" AND `{fo.Key}` = @{fo.Key}";
                        }

                        parametros.Add(new MySqlParameter("@" + fo.Key, val));
                    }
                }

                // -------------------------------
                // Montagem final da consulta
                // -------------------------------
                string sql = $"SELECT {colunas} FROM `{tabela}` WHERE {where}";
                if (!string.IsNullOrWhiteSpace(orderBy))
                    sql += $" ORDER BY {orderBy}";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    foreach (var p in parametros)
                        cmd.Parameters.Add(p);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar consulta na tabela '{tabela}': {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoDB.Fechar();
            }
        }


        public static void PesquisarPorCampo(string tabela, string campo, string texto, DataGridView grid, string colunas = "*")
        {
            Conexao conexaoDB = new Conexao();
            MySqlConnection conn = conexaoDB.Abrir();

            if (conn == null) return;

            try
            {
                string where = "(deletado IS NULL OR deletado = '')";

                if (!string.IsNullOrWhiteSpace(texto))
                {
                    where += $" AND {campo} LIKE @valor";
                }

                string sql = $"SELECT {colunas} FROM {tabela} WHERE {where}";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (!string.IsNullOrWhiteSpace(texto))
                {
                    cmd.Parameters.AddWithValue("@valor", $"%{texto}%");
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
            finally
            {
                conexaoDB.Fechar();
            }
        }

       

        #endregion

        #region Destacar observações no DataGridView

        public static void DestacarObservacoes(DataGridView grid, string colunaObservacao = "observacao")
        {
            if (grid == null) return;

            var col = grid.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => string.Equals(c.Name, colunaObservacao, StringComparison.OrdinalIgnoreCase));

            if (col == null) return;

            var backDefault = grid.DefaultCellStyle.BackColor;
            var backAlt = grid.AlternatingRowsDefaultCellStyle?.BackColor ?? Color.Empty;
            bool usaAlternadas = backAlt != Color.Empty && backAlt != backDefault;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;
                string texto = Convert.ToString(row.Cells[col.Index].Value);

                if (!string.IsNullOrWhiteSpace(texto))
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.Cells[col.Index].ToolTipText = texto;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = usaAlternadas && (row.Index % 2 == 1) ? backAlt : backDefault;
                    row.Cells[col.Index].ToolTipText = null;
                }
            }
        }


        public static class GridUtil
        {
            /// <summary>
            /// Destaca em amarelo as linhas que possuem valores repetidos na combinação dos campos especificados.
            /// </summary>
            /// <param name="dgv">DataGridView para processar.</param>
            /// <param name="campoChave1">Primeiro campo da chave (ex: empresa).</param>
            /// <param name="campoChave2">Segundo campo da chave (ex: patrimonio).</param>
            public static void DestacarDuplicados(DataGridView dgv, string campoChave1, string campoChave2)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                    row.DefaultCellStyle.BackColor = Color.White;

                var contador = new Dictionary<string, int>();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    string valor1 = row.Cells[campoChave1].Value?.ToString().Trim() ?? "";
                    string valor2 = row.Cells[campoChave2].Value?.ToString().Trim() ?? "";

                    if (string.IsNullOrEmpty(valor1) || string.IsNullOrEmpty(valor2)) continue;

                    string chave = valor1 + "||" + valor2;

                    if (contador.ContainsKey(chave))
                        contador[chave]++;
                    else
                        contador[chave] = 1;
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    string valor1 = row.Cells[campoChave1].Value?.ToString().Trim() ?? "";
                    string valor2 = row.Cells[campoChave2].Value?.ToString().Trim() ?? "";
                    string chave = valor1 + "||" + valor2;

                    if (contador.ContainsKey(chave) && contador[chave] > 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

       

        public static DataRow AutenticarUsuario(string usuario, string senha)
        {
           
            usuario = (usuario ?? "").Trim();
            senha = (senha ?? "").Trim();
            

            var conexaoDB = new Conexao();
            var conn = conexaoDB.Abrir();

            if (conn == null)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            try
            {
                string sql = @"
                    SELECT *
                    FROM usuarios 
                    WHERE
                        (deletado IS NULL OR deletado = '' OR deletado = 0 OR deletado = false)                        
                        AND TRIM(usuario) = TRIM(@usuario)                        
                        AND TRIM(senha) = TRIM(@senha)                                                
                    LIMIT 1; ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha); // ⚠️ idealmente, hash da senha aqui
                    
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count == 1)
                            return dt.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoDB.Fechar();
            }
            return null;
        }

        public static bool EditarSemDuplicidade(
            string tabela,
            IDictionary<string, object> camposUnicos, // ex.: {"empresa", "OCKTUS"}, {"patrimonio", "123"}
            string campoId,
            object id,
            bool considerarSomenteAtivos = true,
            bool caseInsensitive = true,
            bool aplicarTrim = true
)
        {
            Conexao conexaoDB = new Conexao();
            MySqlConnection conn = conexaoDB.Abrir();
            if (conn == null) return false;

            try
            {
                var partesWhere = new List<string> { "1=1" };
                var parametros = new List<MySqlParameter>();

                if (considerarSomenteAtivos)
                    partesWhere.Add("(deletado IS NULL OR deletado = '')");

                foreach (var kv in camposUnicos)
                {
                    string col = kv.Key;
                    object val = kv.Value;
                    string pName = "@p_" + col;

                    // Para strings, aplica UPPER/TRIM no SQL (normaliza dos dois lados)
                    if (val is string sVal)
                    {
                        string left = col;
                        string right = pName;

                        if (aplicarTrim) { left = $"TRIM({left})"; right = $"TRIM({right})"; }
                        if (caseInsensitive) { left = $"UPPER({left})"; right = $"UPPER({right})"; }

                        partesWhere.Add($"{left} = {right}");
                        parametros.Add(new MySqlParameter(pName, sVal));
                    }
                    else
                    {
                        // Comparação normal para numéricos/datas/etc.
                        partesWhere.Add($"{col} = {pName}");
                        parametros.Add(new MySqlParameter(pName, val ?? DBNull.Value));
                    }
                }

                partesWhere.Add($"{campoId} <> @id");
                parametros.Add(new MySqlParameter("@id", id));

                string whereSql = string.Join(" AND ", partesWhere);
                string sql = $"SELECT COUNT(*) FROM {tabela} WHERE {whereSql}";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    foreach (var p in parametros) cmd.Parameters.Add(p);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // true = já existe duplicado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar duplicidade: " + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexaoDB.Fechar();
            }
        }


        public static object ConverterDataBanco(string texto)
        {

            if (string.IsNullOrWhiteSpace(texto))
                return DBNull.Value;

            if (DateTime.TryParse(texto, out DateTime data))
                return data.ToString("yyyy-MM-dd");

            return DBNull.Value;
        }


        public static void GerarTermoPreenchido(int idEstoque, string caminhoModelo)
        {
            var dados = BuscarDados(idEstoque);
            if (dados == null)
            {
                MessageBox.Show("Erro ao buscar os dados do termo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string caminhoNovo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Termo_{dados.Usuario}_{DateTime.Now:yyyyMMddHHmmss}.docx");

            // Copia o modelo para o novo caminho
            File.Copy(caminhoModelo, caminhoNovo, overwrite: true);

            using (var doc = DocX.Load(caminhoNovo))
            {
                // Gera a data formatada no estilo "12 de Março de 2024"
                CultureInfo cultura = new CultureInfo("pt-BR");
                string mes = cultura.TextInfo.ToTitleCase(DateTime.Now.ToString("MMMM", cultura));
                string dataFormatada = $"{DateTime.Now.Day} de {mes} de {DateTime.Now.Year}";

                //doc.ReplaceText("{Patrimonio}", dados.patrimonio ?? "");
                doc.ReplaceText("{Patrimonio}", dados.patrimonio ?? "", false, RegexOptions.None, null, null, MatchFormattingOptions.SubsetMatch, true);
                doc.ReplaceText("{Usuario}", dados.Usuario ?? "");
                doc.ReplaceText("{Email}", dados.Email ?? "");
                doc.ReplaceText("{Telefone}", dados.Telefone ?? "");
                doc.ReplaceText("{Marca}", dados.Marca ?? "");
                doc.ReplaceText("{Modelo}", dados.Modelo ?? "");
                doc.ReplaceText("{Serie}", dados.Serie ?? "");
                doc.ReplaceText("{Data}", dataFormatada);

                doc.Save();
            }

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = caminhoNovo,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar o termo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Termo gerado com sucesso: {caminhoNovo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static dynamic BuscarDados(int idEstoque)
        {
            Conexao conexaoDB = new Conexao();
            MySqlConnection conn = conexaoDB.Abrir();

            {
                if (conn == null) return null;

                string sql = @"
                SELECT
                    f.nome AS Usuario,
                    f.email AS Email,
                    f.fone AS Telefone,
                    e.marca AS Marca,
                    e.modelo AS Modelo,
                    e.serie AS Serie,
                    e.patrimonio as Patrimonio
                FROM estoque e
                LEFT JOIN funcionarios f ON f.nome = e.usuario
                WHERE e.id = @id AND (e.deletado IS NULL OR e.deletado = '')";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEstoque);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                patrimonio = reader["Patrimonio"].ToString(),
                                Usuario = reader["Usuario"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telefone = reader["Telefone"].ToString(),
                                Marca = reader["Marca"].ToString(),
                                Modelo = reader["Modelo"].ToString(),
                                Serie = reader["Serie"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static decimal ConverterMoedaParaDecimal(string valor)
        {
            if (decimal.TryParse(valor, NumberStyles.Currency, new CultureInfo("pt-BR"), out decimal resultado))
            {
                return resultado;
            }
            else
            {
                MessageBox.Show("Valor inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static void CarregarCombo
        (
                ComboBox combo,
                string tabela,
                string valorField,
                string displayField,
                bool usarDistinct = false,
                bool incluirEmBranco = true,
                string textoEmBranco = ""
        )
        {
            var conexaoDB = new Conexao();
            var conn = conexaoDB.Abrir();
            if (conn == null) return;

            try
            {
                string where = "WHERE (deletado IS NULL OR deletado = '')";
                string sql;

                if (usarDistinct && valorField == displayField)
                    sql = $"SELECT DISTINCT {displayField} FROM {tabela} {where} ORDER BY {displayField}";
                else if (usarDistinct)
                    sql = $"SELECT DISTINCT {valorField}, {displayField} FROM {tabela} {where} ORDER BY {displayField}";
                else
                    sql = $"SELECT {valorField}, {displayField} FROM {tabela} {where} ORDER BY {displayField}";

                var da = new MySqlDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);

                // Garante as colunas quando DISTINCT trouxer só 1 coluna
                if (!dt.Columns.Contains(valorField)) dt.Columns.Add(valorField, typeof(object));
                if (!dt.Columns.Contains(displayField)) dt.Columns.Add(displayField, typeof(string));

                // ⚠️ Insere a opção em branco (primeira linha)
                if (incluirEmBranco)
                {
                    var dr = dt.NewRow();
                    dr[valorField] = DBNull.Value;   // ou 0, se preferir
                    dr[displayField] = textoEmBranco; // ex.: "" ou "— selecione —"
                    dt.Rows.InsertAt(dr, 0);
                }

                combo.DataSource = dt;
                combo.ValueMember = valorField;
                combo.DisplayMember = displayField;

                // Se quer ver já o branco no DropDownList:
                combo.SelectedIndex = incluirEmBranco ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar combobox: " + ex.Message);
            }
            finally
            {
                conexaoDB.Fechar();
            }
        }


        public static void AtualizarRegistro(string nomeTabela, Dictionary<string, object> campos, string campoChave, object valorChave)
        {
            Conexao conexaoDB = new Conexao();
            MySqlConnection conn = conexaoDB.Abrir();

            if (conn == null) return;

            try
            {
                var atualizacoes = new List<string>();
                foreach (var campo in campos.Keys)
                    atualizacoes.Add($"{campo} = @{campo}");

                string sql = $"UPDATE {nomeTabela} SET {string.Join(", ", atualizacoes)} WHERE {campoChave} = @chave";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                foreach (var campo in campos)
                {
                    if (campo.Value != null && campo.Value.GetType() == typeof(decimal))
                        cmd.Parameters.Add(campo.Key, MySqlDbType.Decimal).Value = (decimal)campo.Value;
                    else
                        cmd.Parameters.AddWithValue("@" + campo.Key, campo.Value ?? DBNull.Value);
                }

                cmd.Parameters.AddWithValue("@chave", valorChave);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
            finally
            {
                conexaoDB.Fechar();

            }
        }
       

        public static bool RegistroExiste(string tabela, Dictionary<string, object> filtros)
        {
            Conexao conexaoDB = new Conexao();
            MySqlConnection conexao = conexaoDB.Abrir();

            if (conexao == null) return false;

            try
            {
                string where = "(deletado IS NULL OR deletado = '')";

                List<MySqlParameter> parametros = new List<MySqlParameter>();

                foreach (var filtro in filtros)
                {
                    where += $" AND {filtro.Key} = @{filtro.Key}";
                    parametros.Add(new MySqlParameter($"@{filtro.Key}", filtro.Value));
                }

                string sql = $"SELECT COUNT(*) FROM {tabela} WHERE {where}";
                using (var comando = new MySqlCommand(sql, conexao))
                {
                    foreach (var param in parametros)

                        comando.Parameters.Add(param);

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexaoDB.Fechar();
            }
        }

        public static void InserirRegistro(string nomeTabela, Dictionary<string, object> campos)
        {
            Conexao conexaoDB = new Conexao();
            MySqlConnection conn = conexaoDB.Abrir();

            if (conn == null) return;

            try
            {
                string colunas = string.Join(", ", campos.Keys);
                string valores = string.Join(", ", campos.Keys.Select(k => "@" + k));

                string sql = $"INSERT INTO {nomeTabela} ({colunas}) VALUES ({valores})";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                foreach (var campo in campos)
                {
                    if (campo.Value != null && campo.Value.GetType() == typeof(decimal))
                        cmd.Parameters.Add(campo.Key, MySqlDbType.Decimal).Value = (decimal)campo.Value;
                    else
                        cmd.Parameters.AddWithValue("@" + campo.Key, campo.Value ?? DBNull.Value);
                }

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir: " + ex.Message);

            }
            finally
            {
                conexaoDB.Fechar();
            }
        }
       
        public static int InserirRegistroRetornandoID(string nomeTabela, Dictionary<string, object> campos)
        {
            Conexao conexaoDB = new Conexao();
            MySqlConnection conn = conexaoDB.Abrir();

            if (conn == null) return -1;

            try
            {
                string colunas = string.Join(", ", campos.Keys);
                string valores = string.Join(", ", campos.Keys.Select(k => "@" + k));

                string sql = $"INSERT INTO {nomeTabela} ({colunas}) VALUES ({valores}); SELECT LAST_INSERT_ID();";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    foreach (var campo in campos)
                    {
                        if (campo.Value != null && campo.Value.GetType() == typeof(decimal))
                            cmd.Parameters.Add(campo.Key, MySqlDbType.Decimal).Value = (decimal)campo.Value;
                        else
                            cmd.Parameters.AddWithValue("@" + campo.Key, campo.Value ?? DBNull.Value);
                    }

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir: " + ex.Message);
                return -1;
            }
            finally
            {
                conexaoDB.Fechar();
            }
        }

        public static void ExcluirRegistros(string tabela, string campoChave, params object[] valores)
        {
            if (valores == null || valores.Length == 0)
                throw new ArgumentException("É necessário informar pelo menos um valor para exclusão.");

            string inClause = string.Join(",", valores.Select((v, i) => "@valor" + i));
            string sql = $"UPDATE {tabela} SET deletado = 1 WHERE {campoChave} IN ({inClause})";

            using (var conn = new Conexao().Abrir())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue("@valor" + i, valores[i]);
                }

                cmd.ExecuteNonQuery();
            }
        }




        #endregion
    }
}
