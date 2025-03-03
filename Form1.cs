using ListaDeCompras.Dao;
using ListaDeCompras.Data;
using ListaDeCompras.Formulario;
using ListaDeCompras.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            try
            {
                using (MySqlConnection conexao = Conexao.Conectar())
                {
                    MessageBox.Show("Conexão estabelecida com sucesso!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("yyyy-MM-dd");
            carregarProdutos();
        }
       

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos produtos = new Produtos();

                produtos.nome = txtNomeProduto.Text;
                produtos.marca = txtMarca.Text;
                produtos.descricao = txtDescricao.Text;
                produtos.categoria = cbCategoria.Text;
                produtos.unidadeMedida = cbUnMedida.Text;
                produtos.dataCadastro = DateTime.Now;

                ProdutoDao produtoDao = new ProdutoDao();
                produtoDao.Salvar(produtos);
                carregarProdutos();
                LimparCampo();
                MessageBox.Show("Produto Cadastrado com sucesso");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados:" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto:" + ex.Message);
            }

        }
     
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProduto.Text))
            {
                MessageBox.Show("Por favor insira um ID");

                return;
            }
            if (!int.TryParse(txtIdProduto.Text, out int idProduto))
            {
                MessageBox.Show("Por favor insira um ID válido");
                txtIdProduto.Focus();
                return;
            }
            try
            {

                ProdutoDao produtoDao = new ProdutoDao();
                produtoDao.Excluir(idProduto);
                MessageBox.Show("Produto excluido com sucesso");
                txtIdProduto.Clear();
                carregarProdutos();
          
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto:" + ex.Message);
            }


        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Editor form = new Editor();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário de edição: {ex.Message}");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdProduto.Text))
                {
                    MessageBox.Show("Por favor insira um ID");

                    return;
                }
                if (!int.TryParse(txtIdProduto.Text, out int idProduto))
                {
                    MessageBox.Show("Por favor insira um ID válido");
                    txtIdProduto.Focus();
                    return;
                }

                ProdutoDao produtoDao = new ProdutoDao();
                DataTable dt = produtoDao.Buscar(idProduto);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvTabela.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado");
                  
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produto:" + ex.Message);
            }
        }

        public void LimparCampo()
        {
            txtNomeProduto.Clear();
            txtMarca.Clear();
            txtIdProduto.Clear();
            txtDescricao.Clear();
            cbCategoria.Items.Clear();
            cbUnMedida.Items.Clear();
        }
        public void carregarProdutos()
        {
            try
            {
                ProdutoDao produtoDao = new ProdutoDao();
                DataTable dt = produtoDao.ListarProdutos();

                if(dt != null && dt.Rows.Count > 0)
                {
                    dgvTabela.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado");
                    dgvTabela.DataSource=null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar tabela produto:" + ex.Message);
            }
        }
        private void txtIdProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }
    }
}
