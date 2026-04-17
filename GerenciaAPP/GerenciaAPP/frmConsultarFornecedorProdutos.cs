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
    public partial class frmConsultarFornecedorProdutos : Form
    {
        public frmConsultarFornecedorProdutos()
        {
            InitializeComponent();
        }

        public string codigoFornecedor { get; set; }

        private void txtBuscarFornecedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_fornecedor AS CÓDIGO," +
                    "cnpj_fornecedor AS CNPJ, razao_social_fornecedor AS 'RAZÃO SOCIAL' FROM tblfornecedores " +
                    "WHERE cnpj_fornecedor LIKE @filtro " +
                    "OR razao_social_fornecedor LIKE @filtro " +
                    "OR nome_fantasia_fornecedor LIKE @filtro " +
                    "OR telefone_fornecedor LIKE @filtro " +
                    "OR celular_fornecedor LIKE @filtro";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Se o usuário pesquisar por Ma (Mateus,
                        //Marcos,Marina).
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarFornecedor.Text +
                            "%");

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvFornecedoresProdutos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarFornecedorProdutos_Load(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_fornecedor AS CÓDIGO," +
                    "cnpj_fornecedor AS CNPJ, razao_social_fornecedor AS 'RAZÃO SOCIAL' FROM tblfornecedores ";


                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvFornecedoresProdutos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void dgvFornecedoresProdutos_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvFornecedoresProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            codigoFornecedor = dgvFornecedoresProdutos.CurrentRow.Cells["CÓDIGO"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();

            
         

        }

        private void dgvFornecedoresProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
