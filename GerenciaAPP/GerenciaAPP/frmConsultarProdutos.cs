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

        private void txtBuscarProdutos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_produto AS CÓDIGO, " +
                    "sku_produto AS SKU, descricao_produto AS 'NOME PRODUTO' FROM tblprodutos " +
                    "WHERE sku_produto LIKE @filtro " +
                    "OR ean_produto LIKE @filtro " +
                    "OR descricao_produto LIKE @filtro";

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
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_produto AS CÓDIGO, " +
                    "sku_produto AS SKU, descricao_produto AS 'NOME PRODUTO' FROM tblprodutos";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

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

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
