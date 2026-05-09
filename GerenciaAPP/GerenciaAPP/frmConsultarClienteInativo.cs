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
    public partial class frmConsultarClienteInativo : Form
    {
        public frmConsultarClienteInativo()
        {
            InitializeComponent();
        }

        public DataTable CarregarClienteInativo()
        {
            try
            {
                Conexao conexao = new Conexao();
                string sql = "SELECT id_cliente AS CÓDIGO, " +
                    "nome_cliente AS NOME, cpf_cliente " +
                    "AS CPF, celular_cliente AS CELULAR, email_cliente AS 'E-MAIL' " +
                    "FROM tblclientes WHERE status_cliente = 'I'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultarClienteInativo.DataSource = dt;
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

        private void frmConsultarClienteInativo_Load(object sender, EventArgs e)
        {
            CarregarClienteInativo();
        }

        private void txtConsultarClienteInativo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_cliente AS CÓDIGO, nome_cliente AS NOME, " +
                    "cpf_cliente AS CPF, celular_cliente AS CELULAR, " +
                    "email_cliente AS 'E-MAIL' " +
                    "FROM tblclientes WHERE (nome_cliente LIKE @filtro " +
                    "OR cpf_cliente LIKE @filtro OR celular_cliente LIKE @filtro OR email_cliente LIKE @filtro) AND (status_cliente = 'I')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtConsultarClienteInativo.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvConsultarClienteInativo.DataSource = dt;
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
                if (dgvConsultarClienteInativo.CurrentRow != null)
                {
                    int id_cliente = Convert.ToInt32(dgvConsultarClienteInativo.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja restaurar este cliente: {dgvConsultarClienteInativo.CurrentRow.Cells["NOME"].Value}?",
                        "Confirmação de Restauração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblclientes SET status_cliente = 'A' WHERE id_cliente = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("id", id_cliente);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Cliente restaurado com sucesso!");

                        CarregarClienteInativo();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar o cliente: " + ex.Message);
            }
        }
    }
}
