using ListaDeCompras.Data;
using ListaDeCompras.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras.Dao
{
    internal class ProdutoDao
    {
        public void Salvar(Produtos produtos)
        {
        try { 
                if (string.IsNullOrWhiteSpace(produtos.nome))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio.");
                    return;
                }
                foreach (char c in produtos.nome)
                {
                    if (!char.IsLetterOrDigit(c) && c != ' ')
                    {
                        MessageBox.Show("O nome do produto deve conter apenas letras, números e espaços.");
                        return;
                    }
                }
                if (string.IsNullOrWhiteSpace(produtos.categoria))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(produtos.unidadeMedida))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(produtos.marca))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio.");
                    return;
                }
                foreach (char c in produtos.marca)
                {
                    if (!char.IsLetterOrDigit(c) && c != ' ')
                    {
                        MessageBox.Show("A marca deve conter apenas letras, números e espaços.");
                        return;
                    }
                }


                string sql = "INSERT INTO produtos (nome, marca, categoria, unidade_medida, descricao, data_cadastro) " +
                                 "VALUES (@nome, @marca, @categoria, @unidade_medida, @descricao, @data_cadastro)";

            
            
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@nome", produtos.nome);
                comando.Parameters.AddWithValue("@marca", produtos.marca);
                comando.Parameters.AddWithValue("@categoria", produtos.categoria);
                comando.Parameters.AddWithValue("@unidade_medida", produtos.unidadeMedida);
                comando.Parameters.AddWithValue("@descricao", produtos.descricao);
                comando.Parameters.AddWithValue("@data_cadastro", produtos.dataCadastro);

                comando.ExecuteNonQuery();
                MessageBox.Show("Produto salvo com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar produto:" + ex.Message );
            }

        }
        public DataTable ListarProdutos()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT*FROM produtos;";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                {
                    da.Fill(dt);    
                }
            }
            catch (MySqlException ex)
            {


                MessageBox.Show("Erro ao listar produto:" + ex.Message);
            }

            return dt;
        }
        public DataTable Buscar(int idProduto)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM produtos WHERE id_produto = @IdProduto;";

            try
            {
                if (idProduto <= 0)
                {
                    MessageBox.Show("ID inválido. Por favor, insira um ID válido.");
                    return null;
                }

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                
                comando.Parameters.AddWithValue("@idProduto", idProduto);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                    
                da.Fill(dt);
                    

                

            }
            catch (MySqlException ex)
            {


                MessageBox.Show("Erro ao buscar produto:" + ex.Message);
            }

            return dt;
        }
        public void Excluir(int idProduto)
        {
            string sql = "DELETE FROM produtos WHERE id_produto = @Id_produto";

          
            try
            {
                if (idProduto <= 0)
                {
                    MessageBox.Show("ID inválido. Por favor, insira um ID válido.");
                    return;
                }

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@id_Produto", idProduto);
                comando.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso!");

            }
            catch (MySqlException ex)
            {


                MessageBox.Show("Erro ao excluir produto:" + ex.Message);
            }
        }

        public void atualizar(Produtos produtos)
        {
            
            try
            {
                if(produtos.idProduto <= 0)
                {
                    MessageBox.Show("ID inválido");
                    return;
                }
                if (string.IsNullOrWhiteSpace(produtos.nome))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio.");
                    return;
                }
                foreach (char c in produtos.nome)
                {
                    if (!char.IsLetterOrDigit(c) && c != ' ')
                    {
                        MessageBox.Show("O nome do produto deve conter apenas letras, números e espaços.");
                        return;
                    }
                }
                if (string.IsNullOrWhiteSpace(produtos.categoria))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(produtos.unidadeMedida))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(produtos.marca))
                {
                    MessageBox.Show("O nome do produto não pode estar vazio.");
                    return;
                }
                foreach (char c in produtos.marca)
                {
                    if (!char.IsLetterOrDigit(c) && c != ' ')
                    {
                        MessageBox.Show("A marca deve conter apenas letras, números e espaços.");
                        return;
                    }
                }
                string sql = "UPDATE produtos SET nome = @nome, marca = @marca, categoria = @categoria, " +
                       "unidade_medida = @unidade_medida, descricao = @descricao WHERE id_produto = @id_produto";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                comando.Parameters.AddWithValue("@nome", produtos.nome);
                comando.Parameters.AddWithValue("@marca", produtos.marca);
                comando.Parameters.AddWithValue("@categoria", produtos.categoria);
                comando.Parameters.AddWithValue("@unidade_medida", produtos.unidadeMedida);
                comando.Parameters.AddWithValue("@descricao", produtos.descricao);
                comando.Parameters.AddWithValue("@id_produto", produtos.idProduto);


                comando.ExecuteNonQuery() ;
                MessageBox.Show("Produto atualizado com sucesso!");

            }
            catch (MySqlException ex)
            {


                MessageBox.Show("Erro ao atualizar produto:" + ex.Message);
            }
        }
    }
}
