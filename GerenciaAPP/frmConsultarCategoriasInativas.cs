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
    public partial class frmConsultarCategoriasInativas : Form
    {
        public frmConsultarCategoriasInativas()
        {
            InitializeComponent();
        }

        public DataTable ConsultarCategoriasInativas()
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_categoria AS CÓDIGO, " +
                    "nome_categoria AS NOME, " +
                    "descricao_categoria AS DESCRIÇÃO " +
                    "FROM tblcategorias " +
                    "WHERE status_categoria = 'I'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCategoriasInativas.DataSource = dt;
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

        private void txtBuscarCategoriasInativas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                string sql = "SELECT id_categoria AS CÓDIGO, " +
                    "nome_categoria AS NOME, " +
                    "descricao_categoria AS DESCRIÇÃO " +
                    "FROM tblcategorias " +
                    "WHERE (nome_categoria LIKE @filtro " +
                    "OR descricao_categoria LIKE @filtro)" +
                    "AND status_categoria = 'I'";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarCategoriasInativas.Text + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCategoriasInativas.DataSource = dt;

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void frmConsultarCategoriasInativas_Load(object sender, EventArgs e)
        {
            ConsultarCategoriasInativas();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoriasInativas.CurrentRow != null)
                {
                    int idCategoria = Convert.ToInt32(dgvCategoriasInativas.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja " +
                        $"restaurar a categoria: " +
                        $"{dgvCategoriasInativas.CurrentRow.Cells["NOME"].Value}",
                        "Confirmação de Restauração",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                            Conexao conexao = new Conexao();

                            string sql = "UPDATE tblcategorias " +
                                "SET status_categoria = 'A' " +
                                "WHERE id_categoria = @id";

                            using (SqlConnection con = conexao.Conectar())
                            {
                                using (SqlCommand cmd = new SqlCommand(sql, con))
                                {
                                    cmd.Parameters.AddWithValue("@id", idCategoria);
                                    cmd.ExecuteNonQuery();
                                    ConsultarCategoriasInativas();
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
