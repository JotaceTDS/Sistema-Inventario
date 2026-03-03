using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;
using System.Globalization;

namespace Inventario.Classes
{
    internal class FormUtil
    {


        // ============================================================
        // 🔹 1) Limpeza e habilitação de campos
        // ============================================================
        public static void LimparCampos( Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                switch (ctrl)
                {
                    case TextBox t: t.Clear(); break;
                    case MaskedTextBox m: m.Clear(); break;
                    case ComboBox c: c.SelectedIndex = -1; break;
                    case CheckBox chk: chk.Checked = false; break;
                }

                if (ctrl.HasChildren)
                    LimparCampos(ctrl);
            }
        }

        public static void HabilitarCampos(Control parent, bool habilitar = true)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox || ctrl is ComboBox || ctrl is CheckBox || ctrl is Button )
                {
                    ctrl.Enabled = habilitar;
                }

                // SE tiver filhos (GroupBox, Panel, TabPage, etc)
                if (ctrl.HasChildren)
                {
                    HabilitarCampos(ctrl, habilitar);
                }

            }
        }   

        public static void AplicarPermissoes(Control parent)
        {
            bool admin = SessaoUsuario.EhAdmin;

            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                {
                    switch (btn.Name)
                    {
                        case "btnNovo":
                            btn.Enabled = admin;   //? false : false; // só habilita no DesabilitarCampos
                            break;
                        case "btnSalvar":
                        case "btnCancelar":
                        case "btnExcluir":
                            btn.Enabled = admin;
                            break;
                    }
                }

                if (ctrl.HasChildren)
                    AplicarPermissoes(ctrl);
            }
        }

        // ============================================================
        // 🔹 2) Listas prontas (UF)
        // ============================================================
        private static readonly string[] UFs =
        {
            "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO",
            "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI",
            "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
        };

        public static void CarregarUFs(ComboBox combo)
        {
            if (combo == null) return;
            combo.Items.Clear();
            combo.Items.AddRange(UFs);
        }


        // ============================================================
        // 🔹 3) Sanitização (remover caracteres especiais)
        // ============================================================
        public static string RemoverMascara(string valor) =>
            Regex.Replace(valor ?? "", "[^0-9]", "");


        // ============================================================
        // 🔹 4) Máscaras automáticas e formatações
        // ============================================================

        public static void FormatarCodigo(DataGridView grid, string nomeColuna = "id")
        {
            grid.CellFormatting += (sender, e) =>
            {
                if (grid.Columns[e.ColumnIndex].Name == nomeColuna && e.Value != null)
                {
                    if (int.TryParse(e.Value.ToString(), out int valor))
                    {
                        e.Value = valor.ToString("D6");
                        e.FormattingApplied = true;
                    }
                }
            };
        }
        public static string FormatarCPFString(string cpf)
        {
            cpf = RemoverMascara(cpf);

            if (cpf.Length != 11)
                return cpf;

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        public static void FormatarCPF(TextBox txt)
        {
            txt.TextChanged += (s, e) =>
            {
                if (txt.Tag as string == "ignore") return;
                txt.Tag = "ignore";

                string dig = RemoverMascara(txt.Text);

                // Limita a 11 dígitos
                if (dig.Length > 11)
                    dig = dig.Substring(0, 11);

                string novo;

                if (dig.Length <= 3)
                {
                    novo = dig;
                }
                else if (dig.Length <= 6)
                {
                    novo = dig.Substring(0, 3) + "." + dig.Substring(3);
                }
                else if (dig.Length <= 9)
                {
                    novo = dig.Substring(0, 3) + "." + dig.Substring(3, 3) + "." + dig.Substring(6);
                }
                else
                {
                    novo = dig.Substring(0, 3) + "." +
                           dig.Substring(3, 3) + "." +
                           dig.Substring(6, 3) + "-" +
                           dig.Substring(9);
                }

                txt.Text = novo;
                txt.SelectionStart = txt.Text.Length;
                txt.Tag = null;
            };
        }


        public static string FormatarTelefone(string telefone)
        {
            telefone = RemoverMascara(telefone);

            if (telefone.Length > 11) 
                telefone = telefone.Substring(0, 11);
                
            if (telefone.Length == 11)
                return Convert.ToUInt64(telefone).ToString(@"(00) 00000\-0000");

            if (telefone.Length == 10)
                return Convert.ToUInt64(telefone).ToString(@"(00) 0000\-0000");

            return telefone;
        }

        public static string FormatarIE(string ie)
        {
            ie = RemoverMascara(ie);
            return ie.Length == 11 ? Convert.ToUInt64(ie).ToString(@"000\.000\.000\.00") : ie;
        }
        public static string FormatarCep(string cep)
        {
            cep = RemoverMascara(cep);

            if (cep.Length > 8)
                cep = cep.Substring(0, 8);

            if ( (cep.Length <= 5))
            {
                return cep;
            }

            return cep.Substring(0, 5) + "-" + cep.Substring(5);
        }

        public static string FormatarCnpj(string cnpj)
        {
            cnpj = RemoverMascara(cnpj);

            if (string.IsNullOrWhiteSpace(cnpj))
                return cnpj;

            // Garante que não exceda 14 dígitos
            if (cnpj.Length > 14)
                cnpj = cnpj.Substring(0, 14);

            // Se não tiver 14 dígitos, retorna sem formatar
            if (cnpj.Length != 14)
                return cnpj;
            
            // Aplica a máscara
            return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");

        }

        public static string FormatarMoeda(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return "0,00";

            // Mantém apenas dígitos
            string somenteDigitos = new string(valor.Where(char.IsDigit).ToArray());

            if (decimal.TryParse(somenteDigitos, out decimal resultado))
            {
                resultado /= 100; // Para considerar os centavos
                return resultado.ToString("N2"); // Formata como moeda com 2 casas decimais
            }

            return "0,00";
        }

        public static void FormatarGridGenerico(DataGridView grid, Dictionary<string, (string Titulo, int Largura, bool Visivel)> configuracoes)
        {
            foreach (var coluna in configuracoes)
            {
                if (grid.Columns.Contains(coluna.Key))
                {
                    grid.Columns[coluna.Key].HeaderText = coluna.Value.Titulo;
                    grid.Columns[coluna.Key].Width = coluna.Value.Largura;
                    grid.Columns[coluna.Key].Visible = coluna.Value.Visivel;
                }
            }
        }

         
        // ============================================================
        // 🔹 5) SOMENTE NÚMEROS
        // ============================================================
        public static void ApenasNumeros(TextBox txt)
        {
            txt.KeyPress += (s, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        // ============================================================
        // 🔹 6) Moeda PROFISSIONAL (enquanto digita)
        // ============================================================
        public static void FormatarMoeda(TextBox txt)
        {
            if (txt.Tag as string == "formatting") return;
            txt.Tag = "formatting";

            try
            {
                string original = txt.Text;
                int cursor = txt.SelectionStart;

                string dig = RemoverMascara(original);
                if (dig.Length == 0)
                {
                    txt.Text = "0,00";
                    txt.SelectionStart = txt.Text.Length;
                    return;
                }
                while (dig.Length < 3)
                    dig = "0" + dig;
                decimal valor = decimal.Parse(dig) / 100;

                string novoTexto = valor.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"));
                txt.Text = novoTexto;

                int diff = novoTexto.Length - original.Length;
                cursor = Math.Max(0, Math.Min(novoTexto.Length, cursor + diff));
                txt.SelectionStart = cursor;
            }
            finally
            {
                txt.Tag = null;
            }
        }

        public static void AplicarAvancoComEnter(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        e.SuppressKeyPress = true; // remove beep

                        // Avança (Enter) ou volta (Shift+Enter)
                        parent.SelectNextControl((Control)s,
                                                 !e.Shift,
                                                 true,
                                                 true,
                                                 true);
                    }
                };

                // Recursivo: pega GroupBox, Panel, TabPage etc.
                if (ctrl.HasChildren)
                    AplicarAvancoComEnter(ctrl);
            }
        }

    }
}
