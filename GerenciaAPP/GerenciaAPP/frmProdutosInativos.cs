using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

                string sql = "SELECT id_produto AS CÓDIGO," +
                    " sku_produto AS SKU, descricao_produto AS 'NOME PRODUTO' FROM tblprodutos WHERE status_produto = 'I'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultarProdutosInativos.DataSource = dt;
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
                return null;
            }
        }

        private void lblBuscarProdutoInatvio_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frmConsultarProdutosInativos_Load(object sender, EventArgs e)
        {
            CarregarProdutosInativos();
        }

        private void txtConsultarProdutoInativo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_produto AS CÓDIGO, " +
                    "sku_produto AS SKU, descricao_produto AS 'NOME PRODTUO' FROM tblprodutos" +
                    " WHERE (sku_produto LIKE @filtro" +
                    " OR ean_produto LIKE @filtro" +
                    " OR descricao_produto LIKE @filtro) AND (status_produto = 'I')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtConsultarProdutoInativo.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvConsultarProdutosInativos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultarProdutosInativos.CurrentRow != null)
                {
                    int id_produto = Convert.ToInt32(dgvConsultarProdutosInativos.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem cereteza que deseja restaurar este produto: {dgvConsultarProdutosInativos.CurrentRow.Cells["NOME PRODUTO"].Value}?",
                        "Restaurar Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblprodutos SET status_produto = 'A' WHERE id_produto = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("id", id_produto);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        CarregarProdutosInativos();
                        MessageBox.Show("Produto restaurado com sucesso!");
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
