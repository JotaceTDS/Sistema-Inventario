using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Classes
{
    public static class SessaoUsuario
    {
        public static int Id { get; set; }
        public static string Nome { get; set; }
        public static string Acesso { get; set; }        
        public static string Empresas { get; set; }

        public static bool EhAdmin => Acesso?.Trim().Equals("Administrador", StringComparison.OrdinalIgnoreCase) == true
                                   || Acesso?.Trim().Equals("A", StringComparison.OrdinalIgnoreCase) == true;

        public static bool EhUsuario => Acesso?.Trim().Equals("Usuario", StringComparison.OrdinalIgnoreCase) == true
                                     || Acesso?.Trim().Equals("U", StringComparison.OrdinalIgnoreCase) == true;

        // ✅ Retorna lista de empresas já pronta para usar em filtros (ex: [ "1", "3", "6" ])
        public static string[] EmpresasLista =>
            string.IsNullOrWhiteSpace(Empresas)
                ? Array.Empty<string>()
                : Empresas.Split(',').Select(e => e.Trim()).Where(e => !string.IsNullOrEmpty(e)).ToArray();

        public static void Limpar()
        {
            Id = 0;
            Nome = string.Empty;
            Acesso = string.Empty;
            Empresas = string.Empty;
        }
    }
}
