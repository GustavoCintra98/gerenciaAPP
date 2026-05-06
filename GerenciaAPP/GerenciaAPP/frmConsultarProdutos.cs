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
    public partial class frmConsultarProdutos : Form
    {
        public frmConsultarProdutos()
        {
            InitializeComponent();
        }

        public DataTable CarregarProdutos()
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_produto AS CÓDIGO, " +
                    "sku_produto AS SKU, descricao_produto AS 'NOME PRODUTO' FROM tblprodutos WHERE status_produto = 'A'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

                        //Preencher o dataTable
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
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);

                return null;
            }
        }

        private void txtBuscarProdutos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_produto AS CÓDIGO, " +
                    "sku_produto AS SKU, descricao_produto AS 'NOME PRODUTO' FROM tblprodutos " +
                    "WHERE (sku_produto LIKE @filtro " +
                    "OR ean_produto LIKE @filtro " +
                    "OR descricao_produto LIKE @filtro) AND (status_produto = 'A')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Se o usuário pesquisar por Ma (Mateus,
                        //Marcos,Marina).
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarProdutos.Text +
                            "%");

                        //Preencher o dataTable
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

        private void frmConsultarProdutos_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // se o campo selecionado for diferente de "null", então a deleção pode acontecer
                if (dgvProdutos.CurrentRow != null)
                {
                    int idProduto = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja deletar este produto: {dgvProdutos.CurrentRow.Cells["NOME PRODUTO"].Value}?", 
                        "Confirmação de Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblprodutos SET status_produto = 'I' WHERE id_produto = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idProduto);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Produto deletado com sucesso!");

                        CarregarProdutos();

                    }    
                    
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar: " + ex.Message);
            }
        }   

        private void ctxMenuProdutos_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
