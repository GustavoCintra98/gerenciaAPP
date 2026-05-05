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
    public partial class frmCadCategorias : Form
    {
        public frmCadCategorias()
        {
            InitializeComponent();
        }

        private void frmCadCategorias_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instânciando a classe de conexão.
            Conexao conexao = new Conexao();

            //Criando a query SQL.
            string sql = "INSERT INTO tblcategorias VALUES (@nome, @descricao, @satus_categoria)";

            //Abrindo a conexão para inserção

            try
            {
                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        cmd.Parameters.AddWithValue("@nome", txtNomeCategoria.Text);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricaoCategoria.Text);
                        cmd.Parameters.AddWithValue("@status_categoria", "A");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Categoria cadastrada com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtNomeCategoria.Clear();
                        txtDescricaoCategoria.Clear();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + 
                    ex.Message, "Erro", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
    }
}
