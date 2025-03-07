using ListaDeCompras.Dao;
using ListaDeCompras.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras.Formulario
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            lbData.Text = DateTime.Now.ToString("yyyy-MM-dd");
            
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                Produtos produtos = new Produtos();

                produtos.idProduto = Convert.ToInt32(txtIdProduto.Text);
                produtos.nome = txtNomeProduto.Text;
                produtos.marca = txtMarca.Text;
                produtos.descricao = txtDescricao.Text;
                produtos.categoria = cbCategoria.Text;
                produtos.unidadeMedida = cbUnMedida.Text;
                produtos.dataCadastro = DateTime.Now;

                ProdutoDao produtoDao = new ProdutoDao();
                produtoDao.atualizar(produtos);
                carregarProdutos();
               
                MessageBox.Show("Produto Cadastrado com sucesso");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto:" + ex.Message);
            }
        }
        public void carregarProdutos()
        {
            try
            {
                ProdutoDao produtoDao = new ProdutoDao();
                DataTable dt = produtoDao.ListarProdutos();

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgvTabela.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado");
                    dgvTabela.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar tabela produto:" + ex.Message);
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

        private void gpCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Clear();
            txtMarca.Clear();
            txtIdProduto.Clear();
            txtDescricao.Clear();
            cbCategoria.Items.Clear();
            cbUnMedida.Items.Clear();
        }

        private void txtIdProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
