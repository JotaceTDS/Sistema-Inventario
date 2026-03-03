using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Classes
{
    public class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }

        public static async Task<Endereco> BuscaEnderecoPorCep(string cep)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

                    if (!response.IsSuccessStatusCode)
                        return null;

                    var json = await response.Content.ReadAsStringAsync();

                    // Verifica se a API retornou um erro
                    if (json.Contains("\"erro\": true"))
                        return null;

                    var endereco = JsonConvert.DeserializeObject<Endereco>(json);
                    return endereco;
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
