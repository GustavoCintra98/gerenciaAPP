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
    public partial class frmConsultarClientesInativos : Form
    {
        public frmConsultarClientesInativos()
        {
            InitializeComponent();
        }

        public DataTable ConsultarClientesInativos()
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_cliente AS CÓDIGO, " +
                    "nome_cliente AS NOME,cpf_cliente AS CPF,celular_cliente " +
                    "AS CELULAR,email_cliente AS 'E-MAIL' FROM tblclientes WHERE status_cliente = 'I'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvClientesInativos.DataSource = dt;

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

        private void txtBuscarClientesInativos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_cliente AS CÓDIGO, nome_cliente AS NOME, " +
                    "cpf_cliente AS CPF,celular_cliente AS CELULAR, " +
                    "email_cliente AS 'E-MAIL' " +
                    "FROM tblclientes WHERE (nome_cliente LIKE @filtro " +
                    "OR cpf_cliente LIKE @filtro OR email_cliente LIKE @filtro) AND (status_cliente = 'I')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Se o usuário pesquisar por Ma (Mateus,
                        //Marcos,Marina).
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarClientesInativos.Text +
                            "%");

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvClientesInativos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarClientesInativos_Load(object sender, EventArgs e)
        {
            ConsultarClientesInativos();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientesInativos.CurrentRow != null)
                {
                    int idCategoria = Convert.ToInt32(dgvClientesInativos.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja " +
                        $"restaurar a categoria: " +
                        $"{dgvClientesInativos.CurrentRow.Cells["NOME"].Value}",
                        "Confirmação de Restauração",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblclientes " +
                            "SET status_cliente = 'A' " +
                            "WHERE id_cliente = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idCategoria);
                                cmd.ExecuteNonQuery();
                                ConsultarClientesInativos();
                            }
                        }
                        MessageBox.Show("Categoria restaurada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar a categoria: " + ex.Message);
            }
        }
    }

}

