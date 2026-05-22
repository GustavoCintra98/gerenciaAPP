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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe de conexão
            Conexao conexao = new Conexao();

            //Criando a query SQL
            string sql = "INSERT INTO tblclientes VALUES (@nomecompleto,@cpf,@datanascimento," +
             "@genero,@cep,@endereco,@numero,@bairro,@cidade,@uf,@complemento,@telefone,@celular," +
             "@whatsapp,@email,@observacoes,@status)";

            try
            {
                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCliente.Text);
                        cmd.Parameters.AddWithValue("@cpf", mskCPFCliente.Text);
                        cmd.Parameters.AddWithValue("@datanascimento", mskDataNascimento.Text);
                        cmd.Parameters.AddWithValue("@genero", cmbGenero.Text);
                        cmd.Parameters.AddWithValue("@cep", mskCEP.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumeroEndereco.Text);
                        cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@uf", txtEstado.Text);
                        cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                        cmd.Parameters.AddWithValue("@celular", mskCelular.Text);
                        //Abaixo o uso do operador ternário "?"
                        cmd.Parameters.AddWithValue("@whatsapp", chkWhatsapp.Checked ? "S" : "N" );
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@observacoes", txtObservacoes.Text);
                        cmd.Parameters.AddWithValue("@status", "A");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente cadastrado com sucesso!", 
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNomeCliente.Clear();
                        mskCPFCliente.Clear();
                        mskDataNascimento.Clear();
                        cmbGenero.Items.Clear();
                        mskCEP.Clear();
                        txtEndereco.Clear();
                        txtNumeroEndereco.Clear();
                        txtBairro.Clear();
                        txtCidade.Clear();
                        txtEstado.Clear();
                        txtComplemento.Clear();
                        mskTelefone.Clear();
                        mskCelular.Clear();
                        chkWhatsapp.Checked = false;
                        txtEmail.Clear();
                        txtObservacoes.Clear();

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
