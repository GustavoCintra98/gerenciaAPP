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
    public partial class frmConsultarFornecedorInativo : Form
    {
        public frmConsultarFornecedorInativo()
        {
            InitializeComponent();
        }

        public DataTable ConsultarFornecedorInativo()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT id_fornecedor AS CÓDIGO, " +
                    "cnpj_fornecedor AS CNPJ, razao_social_fornecedor AS 'RAZÃO SOCIAL' FROM tblfornecedores WHERE status_fornecedor = 'I'";
                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultarFornecedorInativo.DataSource = dt;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarFornecedorInativo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_fornecedor AS CÓDIGO, " +
                    "cnpj_fornecedor AS CNPJ, razao_social_fornecedor AS 'RAZÃO SOCIAL' FROM tblfornecedores" +
                    " WHERE (cnpj_fornecedores LIKE @fitro " +
                    "OR razao_social_fornecedor LIKE @filtro" +
                    " OR nome_fantasia_fornecedor LIKE @filtro" +
                    " OR telefone_fornecedor LIKE @filtro" +
                    " OR celular_fornecedor LIKE @filtro) AND (status_fornecedor = 'I')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtBuscarFornecedorInativo.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvConsultarFornecedorInativo.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarFornecedorInativo_Load(object sender, EventArgs e)
        {
            ConsultarFornecedorInativo();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultarFornecedorInativo.CurrentRow != null)
                {
                    int id_forncedor = Convert.ToInt32(dgvConsultarFornecedorInativo.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja restaurar este fornecedor: {dgvConsultarFornecedorInativo.CurrentRow.Cells["RAZÃO SOCIAL"].Value}?",
                        "Restaurar Fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblfornecedores SET status_fornecedor = 'A' WHERE id_fornecedor = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("id", id_forncedor);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Fornecedor restaurado com sucesso!");

                        ConsultarFornecedorInativo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar o fornecedor: " + ex.Message);
            }
        }
    }
}
