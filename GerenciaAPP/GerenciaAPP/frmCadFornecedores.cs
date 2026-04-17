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
    public partial class frmCadFornecedores : Form
    {
        public frmCadFornecedores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instânciando a classe conexão
            Conexao conexao = new Conexao();

            //Definir a query (consulta) SQL
            string sql = "INSERT INTO tblfornecedores VALUES (@cnpj,@razaosocial,@nomefantasia,@porte,@cnaeprincipal,@cnaesecundario, @inscricaomunicipal,@inscricaoestadual, @cep,@endereco,@numero,@bairro,@cidade, @uf,@complemento,@telefone,@celular,@email,@responsavel,@observacoes)";

            try
            {
                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@cnpj", mskCNPJ.Text);
                        cmd.Parameters.AddWithValue("@razaosocial", txtRazaoSocial.Text);
                        cmd.Parameters.AddWithValue("@nomefantasia", txtNomeFantasia.Text);
                        cmd.Parameters.AddWithValue("@porte", txtPorte.Text);
                        cmd.Parameters.AddWithValue("@cnaeprincipal", txtCNAEPrincipal.Text);
                        cmd.Parameters.AddWithValue("@cnaesecundario", txtCNAESecundario.Text);
                        cmd.Parameters.AddWithValue("@inscricaomunicipal", txtInscricaoMunicipal.Text);
                        cmd.Parameters.AddWithValue("@inscricaoestadual", txtInscricaoEstadual.Text);
                        cmd.Parameters.AddWithValue("@cep", mskCEP.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@uf", txtUF.Text);
                        cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                        cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                        cmd.Parameters.AddWithValue("@celular", mskCelular.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@responsavel", txtResponsavel.Text);
                        cmd.Parameters.AddWithValue("@observacoes", txtObservacoes.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fornecedor cadastrado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        mskCNPJ.Clear();
                        txtRazaoSocial.Clear();
                        txtNomeFantasia.Clear();
                        txtPorte.Clear();
                        txtCNAEPrincipal.Clear();
                        txtCNAESecundario.Clear();
                        txtInscricaoMunicipal.Clear();
                        txtInscricaoEstadual.Clear();
                        mskCEP.Clear();
                        txtEndereco.Clear();
                        txtNumero.Clear();
                        txtBairro.Clear();
                        txtCidade.Clear();
                        txtUF.Clear();
                        txtComplemento.Clear();
                        mskTelefone.Clear();
                        mskCelular.Clear();
                        txtEmail.Clear();
                        txtResponsavel.Clear();
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
