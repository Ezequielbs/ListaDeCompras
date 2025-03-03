using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ListaDeCompras.Data
{
    internal class Conexao
    {
        

        private static string  strConexao = "server=localhost;Port=3306;uid=root;pwd=#Borher09;database=ListaDeCompras1";

        public static MySqlConnection Conectar()
        {
            try
            {
              MySqlConnection conexao = new MySqlConnection(strConexao);
               conexao.Open();
                return conexao;
            }
            catch (MySqlException ex)
            {

                throw new Exception("Erro ao conectar ao banco de dados:"+ ex.Message);
            }
        }
    }

}

