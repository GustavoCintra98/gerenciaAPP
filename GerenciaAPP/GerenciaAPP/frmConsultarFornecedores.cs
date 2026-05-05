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
    public partial class frmConsultarFornecedores : Form
    {
        public frmConsultarFornecedores()
        {
            InitializeComponent();
        }

        public DataTable ConsultarFornecedores()
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_fornecedor AS CÓDIGO," +
                    "cnpj_fornecedor AS CNPJ, razao_social_fornecedor AS 'RAZÃO SOCIAL' FROM tblfornecedores WHERE status_forncedor = 'A'";


                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvFornecedores.DataSource = dt;

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

        private void txtBuscarFornecedores_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_fornecedor AS CÓDIGO," +
                    "cnpj_fornecedor AS CNPJ, razao_social_fornecedor AS 'RAZÃO SOCIAL' FROM tblfornecedores " +
                    "WHERE (cnpj_fornecedor LIKE @filtro " +
                    "OR razao_social_fornecedor LIKE @filtro " +
                    "OR nome_fantasia_fornecedor LIKE @filtro " +
                    "OR telefone_fornecedor LIKE @filtro " +
                    "OR celular_fornecedor LIKE @filtro) AND (status_fornecedor = 'A')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Se o usuário pesquisar por Ma (Mateus,
                        //Marcos,Marina).
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarFornecedores.Text +
                            "%");

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvFornecedores.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarFornecedores_Load(object sender, EventArgs e)
        {
            ConsultarFornecedores();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedores.CurrentRow != null)
                {
                    int idFornecedor = Convert.ToInt32(dgvFornecedores.CurrentRow.Cells["CÓDIGO"].Value);
                    DialogResult result = MessageBox.Show($"Tem certeza que deseja excluir " +
                        $"{dgvFornecedores.CurrentRow.Cells["RAZÃO SOCIAL"].Value}", "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();
                        string sql = "UPDATE tblfornecedores " +
                            "SET status_fornecedor = 'I' " +
                            "WHERE id_fornecedor = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idFornecedor);
                                cmd.ExecuteNonQuery();

                                ConsultarFornecedores();
                            }

                            MessageBox.Show("Fornecedor removido com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o fornecedor: " + ex.Message);
            }
        }

        private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

