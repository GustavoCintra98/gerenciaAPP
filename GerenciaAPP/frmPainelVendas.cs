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
    public partial class frmPainelVendas : Form
    {
        public frmPainelVendas()
        {
            InitializeComponent();
        }

        private void ConfigurarColunasGrid()
        {
            dgvItensVenda.Columns.Add("colNumero", "ITEM");
            dgvItensVenda.Columns.Add("colDescricao", "PRODUTO");
            dgvItensVenda.Columns.Add("colqtde", "QUANTIDADE");
            dgvItensVenda.Columns.Add("colValor", "VALOR R$");
        }

        private void BuscarProduto(string codigo)
        {
            Conexao conexao = new Conexao();

            //Validar campo preenchido
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return;
            }

            try
            {

                string sql = "SELECT descricao_produto, " +
                    "preco_venda_produto FROM tblprodutos " +
                    "WHERE (sku_produto = @codigo OR ean_produto = @codigo) AND " +
                    "status_produto = 'A'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ;
                            if (reader.Read())
                            {
                                string nomeProduto = reader["descricao_produto"].ToString();
                                decimal valorProduto = Convert.ToDecimal(reader["preco_venda_produto"]);

                                lblRetornoProduto.Text = nomeProduto;
                                lblRetornoValor.Text = valorProduto.ToString("C2");

                                AdicionarItemNaTabela(nomeProduto, valorProduto);

                                txtCodigoBarras.Clear();
                                txtCodigoBarras.Focus();

                            }

                            else
                            {
                                MessageBox.Show("Produto não cadastrado!",
                                    "Aviso!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
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

        
        private void AdicionarItemNaTabela(string nome, decimal valor)
        {
            int numItem = dgvItensVenda.Rows.Count + 1;

            int qtde = 1;

            // Adicionar linha no DataGridView (seguindo a ordem das colunas)

            dgvItensVenda.Rows.Add(numItem, nome, qtde, valor.ToString("F2"));
        }


        private void AtualizarToatisVenda()
        {
            decimal subTotalGeral = 0;

            // Passar de linha em linha no grid

            foreach (DataGridViewRow linha in dgvItensVenda.Rows)
            {
                if (linha.Cells["colTotal"].Value != null)
                {
                    subTotalGeral += Convert.ToDecimal(linha.Cells["colTotal"].Value);

                    lblRetornoSubtotal.Text = subTotalGeral.ToString("C2");
                }
            }
        }


        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            BuscarProduto(txtCodigoBarras.Text);
        }

        private void frmPainelVendas_Load(object sender, EventArgs e)
        {
            ConfigurarColunasGrid();
        }

        private void dgvItensVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
