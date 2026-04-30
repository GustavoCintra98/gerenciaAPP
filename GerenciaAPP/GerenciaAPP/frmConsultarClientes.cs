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
    public partial class frmConsultarClientes : Form
    {
        public frmConsultarClientes()
        {
            InitializeComponent();
        }

        public DataTable ConsultarClientes()
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_cliente AS CÓDIGO, " +
                    "nome_cliente AS NOME,cpf_cliente AS CPF,celular_cliente " +
                    "AS CELULAR,email_cliente AS 'E-MAIL' FROM tblclientes";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvClientes.DataSource = dt;

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

        private void ctx_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_cliente AS CÓDIGO, nome_cliente AS NOME, " +
                    "cpf_cliente AS CPF,celular_cliente AS CELULAR, " +
                    "email_cliente AS 'E-MAIL' " +
                    "FROM tblclientes WHERE nome_cliente LIKE @filtro " +
                    "OR cpf_cliente LIKE @filtro OR email_cliente LIKE @filtro";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Se o usuário pesquisar por Ma (Mateus,
                        //Marcos,Marina).
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarClientes.Text +
                            "%");

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvClientes.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            ConsultarClientes();
        }

        private void deletarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja inativa o cliente: " +
                        $"{dgvClientes.CurrentRow.Cells["NOME"].Value}","Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblclientes SET status_cliente = 'I' WHERE id_cliente = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idCliente);
                                cmd.ExecuteNonQuery();

                                ConsultarClientes();
                            }
                        }
                        MessageBox.Show("Cliente removido com sucesso!", 
                            "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o cliente: " + ex.Message);
            }
        }
    }
}