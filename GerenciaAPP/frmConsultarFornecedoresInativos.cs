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
    public partial class frmConsultarFornecedoresInativos : Form
    {
        public frmConsultarFornecedoresInativos()
        {
            InitializeComponent();
        }

        public DataTable CarregarFornecedoresInativos()
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_fornecedor AS CÓDIGO,cnpj_fornecedor " +
                    "AS CNPJ,razao_social_fornecedor AS 'RAZÃO SOCIAL' " +
                    "FROM tblfornecedores WHERE status_fornecedor = 'I'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvFornecedoresInativos.DataSource = dt;

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
                Conexao conexao = new Conexao();

                string sql = "SELECT id_fornecedor AS CÓDIGO, " +
                    "cnpj_fornecedor AS CNPJ, " +
                    "razao_social_fornecedor AS 'RAZÃO SOCIAL' " +
                    "FROM tblfornecedores " +
                    "WHERE (cnpj_fornecedor LIKE @filtro " +
                    "OR razao_social_fornecedor LIKE @filtro " +
                    "OR nome_fantasia_fornecedor LIKE @filtro " +
                    "OR telefone_fornecedor LIKE @filtro " +
                    "OR celular_fornecedor LIKE @filtro)" +
                    "AND (status_fornecedor = 'I')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarFornecedoresInativos.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvFornecedoresInativos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarFornecedoresInativos_Load(object sender, EventArgs e)
        {
            CarregarFornecedoresInativos();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedoresInativos.CurrentRow != null)
                {
                    int idFornecedor = Convert.ToInt32(dgvFornecedoresInativos
                        .CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja " +
                        $"reativar o fornecedor: " +
                        $"{dgvFornecedoresInativos.CurrentRow.Cells["RAZÃO SOCIAL"].Value}",
                        "Confirmação de Restauração",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblfornecedores SET status_fornecedor = 'A' WHERE id_fornecedor = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idFornecedor);
                                cmd.ExecuteNonQuery();
                                CarregarFornecedoresInativos();
                            }
                        }

                        MessageBox.Show("Fornecedor restaurado com sucesso!");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar " +
                    "a fornecedor: " + ex.Message);
            }

        }

        private void ctxConsultarFornecedoresInativos_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
