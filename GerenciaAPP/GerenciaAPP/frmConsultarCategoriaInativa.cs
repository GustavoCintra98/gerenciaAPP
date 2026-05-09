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
    public partial class frmConsultarCategoriaInativa : Form
    {
        public frmConsultarCategoriaInativa()
        {
            InitializeComponent();
        }

        public DataTable CarregarCategoriasInativas()
        {

            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();
                //Query (Consulta) 
                string sql = "SELECT id_categoria AS CÓDIGO, " +
                    "nome_categoria AS NOME, descricao_categoria " +
                    "AS DESCRIÇÃO FROM tblcategorias WHERE status_categoria = 'I'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultarCategoriaInativa.DataSource = dt;
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

        private void lblConsultarCategoriaInativa_Click(object sender, EventArgs e)
        {

        }

        private void txtConsultarCategoriaInativa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_categoria AS CÓDIGO, nome_categoria AS NOME, descricao_categoria AS DESCRIÇÃO FROM tblcategorias " +
                    "WHERE (nome_categoria LIKE @filtro " +
                    "OR descricao_categoria LIKE @filtro) AND (status_categoria = 'I')";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Usuário digitará o nome ou parte do nome da categoria para realizar a busca.
                        cmd.Parameters.AddWithValue("@filtro", "%" + txtConsultarCategoriaInativa.Text + "%");

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvConsultarCategoriaInativa.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarCategoriaInativa_Load(object sender, EventArgs e)
        {
            CarregarCategoriasInativas();
        }

        private void dgvConsultarCategoriaInativa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultarCategoriaInativa.CurrentRow != null)
                {
                    int idCategoria = Convert.ToInt32(dgvConsultarCategoriaInativa.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja restaura esta categoria: {dgvConsultarCategoriaInativa.CurrentRow.Cells["NOME"].Value}?",
                        "Confirmação de Restauração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "UPDATE tblcategorias SET status_categoria = 'A' WHERE id_categoria = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idCategoria);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Categoria restaurada com sucesso!");

                        CarregarCategoriasInativas();

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao restaurar: " + ex.Message);
            }
        }
    }
}
