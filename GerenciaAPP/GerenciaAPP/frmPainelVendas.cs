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
    public partial class frmPainelVendas : Form
    {
        public frmPainelVendas()
        {
            InitializeComponent();
        }

        private void BuscarProduto(string codigo)
        {
            Conexao conexao = new Conexao();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                return;
            }

            try
            {

                string sql = "SELECT descricao_produto," +
                    " preco_venda_produto FOM tblprodutos" +
                    " WHERE (sku_produto OR ean_produto = @codigo) ADN" +
                    " status_produto = 'A'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {



                            if (reader.Read())
                            {
                                string nomeProduto = reader["descricao_produto"].ToString();
                                decimal valorProduto = Convert.ToDecimal(reader["preco_venda_produto"]);

                                lblRetornoProduto.Text = nomeProduto;
                                lblRetornoValor.Text = valorProduto.ToString();

                                txtCodigoBarras.Clear();
                                txtCodigoBarras.Focus();

                            }

                            else
                            {
                                MessageBox.Show("Produto não cadastrado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                txtCodigoBarras.Clear();
                                txtCodigoBarras.Focus();
                            }
                        }
                    }   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }


        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
