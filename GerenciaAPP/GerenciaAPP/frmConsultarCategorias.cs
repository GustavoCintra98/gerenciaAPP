using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciaAPP
{
    public partial class frmConsultarCategorias : Form
    {
        public frmConsultarCategorias()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void frmConsultarCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_categoria AS CÓDIGO, " +
                    "nome_categoria AS NOME, descricao_categoria " +
                    "AS DESCRIÇÃO FROM tblcategorias";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCategorias.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void txtBuscarCategorias_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT id_categoria AS CÓDIGO, nome_categoria AS NOME, descricao_categoria AS DESCRIÇÃO FROM tblcategorias " +
                    "WHERE nome_categoria LIKE @filtro " +
                    "OR descricao_categoria LIKE @filtro";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Se o usuário pesquisar por ca (Canecas,
                        //Canetas,Bonecas).
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtBuscarCategorias.Text +
                            "%");

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvCategorias.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.CurrentRow != null)
                {
                    int idCategoria = Convert.ToInt32(dgvCategorias.CurrentRow.Cells["CÓDIGO"].Value);

                    DialogResult result = MessageBox.Show($"Tem certeza que deseja deletar esta categoria: {dgvCategorias.CurrentRow.Cells["NOME"].Value}?",
                        "Confirmação de Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Conexao conexao = new Conexao();

                        string sql = "DELETE FROM tblcategorias WHERE id_categoria = @id";

                        using (SqlConnection con = conexao.Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", idCategoria);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Categoria deletada com sucesso!");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar a categoria: " + ex.Message);
            }

        }
    }
}
