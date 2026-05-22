using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GerenciaAPP
{
    public partial class frmConsultarProdutosInativos : Form
    {
        public frmConsultarProdutosInativos()
        {
            InitializeComponent();
        }

        public DataTable CarregarProdutosInativos()
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_produto AS CÓDIGO, " +
                    "sku_produto AS SKU, descricao_produto AS 'NOME PRODUTO' " +
                    "FROM tblprodutos WHERE status_produto = 'I'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvProdutos.DataSource = dt;
                        return dt;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                return null;
            }
        }

        private void txtBuscarProdutos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_produto AS CÓDIGO," +
                    "sku_produto AS SKU, " +
                    "descricao_produto AS 'NOME PRODUTO' " +
                    "FROM tblprodutos WHERE (sku_produto LIKE @filtro " +
                    "OR ean_produto LIKE @filtro " +
                    "OR descricao_produto LIKE @filtro) " +
                    "AND (status_produto = 'I')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarProdutos.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvProdutos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarProdutosInativos_Load(object sender, EventArgs e)
        {
            CarregarProdutosInativos();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvProdutos.CurrentRow != null)
                {
                    int idProduto = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Deseja " +
                        $"restaurar o produto: " +
                        $"{dgvProdutos.CurrentRow.Cells["NOME PRODUTO"].Value} ?",
                        "Confirmação de Restauração",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)

                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblprodutos " +
                            "SET status_produto = 'A' WHERE id_produto = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idProduto);
                                cmd.ExecuteNonQuery();
                                CarregarProdutosInativos();
                                MessageBox.Show("Produto reativado com sucesso!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar o produto: " + ex.Message);
            }
        
            }
        }
    }

