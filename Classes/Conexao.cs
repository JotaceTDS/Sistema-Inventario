using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario.Classes
{
    public class Conexao
    {
        private MySqlConnection conexao;

        public MySqlConnection Abrir()
        {
            try
            {
                string conexaoString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString;

                if (string.IsNullOrEmpty(conexaoString))
                {
                    throw new Exception("String de conexão não encontrada no App.Config.");
                }
                conexao = new MySqlConnection(conexaoString);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
                return null;
            }
        }
        public void Fechar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        public static string CaminhoSistema
        {
            get
            {
                return ConfigurationManager.AppSettings["CaminhoSistema"];
            }
        }
    }
}
