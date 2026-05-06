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
                    "OR descricao_categoria LIKE @filtro) AND (statu_categoria = 'I')";

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
    }
}
