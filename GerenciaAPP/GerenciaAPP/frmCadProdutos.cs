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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GerenciaAPP
{
    public partial class frmCadProdutos : Form
    {
        private DateTime dataValidade;

        public frmCadProdutos()
        {
            InitializeComponent();
        }

        private void dtpDataValidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe
            Conexao conexao = new Conexao();

            //Criando a query SQL
            string sql = "INSERT INTO tblprodutos VALUES (@sku," +
                "@ean,@descricao,@categoria,@unidade,@prccompra," +
                "@prcvenda,@peso,@composicao,@comprimento," +
                "@largura, @profundidade, @ncm,@fornecedor," +
                "@estminimo,@estmaximo,@marca,@datavalidade," +
                "@descricaodetalhada,@img1,@img2,@img3,@img4)";

            try
            {
                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@sku", txtSKU.Text);
                        cmd.Parameters.AddWithValue("@ean", txtEAN.Text);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@categoria", cmbCategoria.SelectedValue);
                        cmd.Parameters.AddWithValue("@unidade", txtUnidade.Text);
                        cmd.Parameters.AddWithValue("@prccompra", numUpPrecoCompra.Value);
                        cmd.Parameters.AddWithValue("@prcvenda", numUpPrecoVenda.Value);
                        cmd.Parameters.AddWithValue("@peso", numUpPeso.Value);
                        cmd.Parameters.AddWithValue("@composicao", cmbComposicao.Text);
                        cmd.Parameters.AddWithValue("@comprimento", numUpComprimento.Value);
                        cmd.Parameters.AddWithValue("@largura", numUpLargura.Value);
                        cmd.Parameters.AddWithValue("@profundidade", numUpProfundidade.Value);
                        cmd.Parameters.AddWithValue("@ncm", txtNCM.Text);
                        cmd.Parameters.AddWithValue("@fornecedor", txtFornecedor.Text);
                        cmd.Parameters.AddWithValue("@estminimo", numUpEstoqueMinimo.Value);
                        cmd.Parameters.AddWithValue("@estmaximo", numUpEstoqueMaximo.Value);
                        cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                        //cmd.Parameters.AddWithValue("@datavalidade", dtpDataValidade.Value);
                        cmd.Parameters.AddWithValue("@descricaodetalhada", txtDescricaoDetalhada.Text);
                        cmd.Parameters.AddWithValue("@img1", "");
                        cmd.Parameters.AddWithValue("@img2", "");
                        cmd.Parameters.AddWithValue("@img3", "");
                        cmd.Parameters.AddWithValue("@img4", "");

                        DateTime? dataValidade = null;

                        if (chkDataValidade.Checked)
                        {
                            dataValidade = dtpDataValidade.Value;
                        }

                        if (dataValidade.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@datavalidade", dataValidade);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@datavalidade", DBNull.Value);
                        }





                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Produto cadastrado com sucesso!",
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtSKU.Clear();
                        txtEAN.Clear();
                        txtDescricao.Clear();
                        //cmbCategoria.Items.Clear();
                        cmbCategoria.SelectedIndex = -1;
                        txtUnidade.Clear();
                        numUpPrecoCompra.Value = 0;
                        numUpPrecoVenda.Value = 0;
                        numUpPeso.Value = 0;
                        cmbComposicao.Items.Clear();
                        numUpComprimento.Value = 0;
                        numUpLargura.Value = 0;
                        numUpProfundidade.Value = 0;
                        txtNCM.Clear();
                        txtFornecedor.Clear();
                        numUpEstoqueMinimo.Value = 0;
                        numUpEstoqueMaximo.Value = 0;
                        txtMarca.Clear();
                        dtpDataValidade.Value = DateTime.Today;
                        txtDescricaoDetalhada.Clear();
                        lblRazaoSocial.Text = string.Empty;
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

        private void grbInformacoesProduto_Enter(object sender, EventArgs e)
        {

        }

        private void txtFornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFornecedor_DoubleClick(object sender, EventArgs e)
        {
            frmConsultarFornecedorProdutos frmConsultarFornecedorProdutos = new frmConsultarFornecedorProdutos();

            if (frmConsultarFornecedorProdutos.ShowDialog() == DialogResult.OK)
            {
                txtFornecedor.Text = frmConsultarFornecedorProdutos.codigoFornecedor;
                numUpEstoqueMinimo.Focus();
            }

        }

        private void txtFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a conexão
                Conexao conexao = new Conexao();

                //Query (Consulta) 
                string sql = "SELECT razao_social_fornecedor FROM tblfornecedores " +
                    "WHERE id_fornecedor LIKE @filtro";

                using (SqlConnection con = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //Se o usuário pesquisar por Ma (Mateus,
                        //Marcos,Marina).
                        cmd.Parameters.AddWithValue("@filtro",
                            "%" + txtFornecedor.Text +
                            "%");

                        //Preencher o dataTable
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        lblRazaoSocial.Text = dt.Rows[0]["razao_social_fornecedor"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar a busca: " + ex.Message);
            }
        }

        private void lblPrecoCompra_Click(object sender, EventArgs e)
        {

        }

        private void consultarCategorias()
        {
            Conexao conexao = new Conexao();

            string sql = "SELECT * FROM tblcategorias";

            using (SqlConnection con = conexao.Conectar())
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        cmbCategoria.DataSource = dt;
                        cmbCategoria.DisplayMember = "nome_categoria";
                        cmbCategoria.ValueMember = "id_categoria";


                    }
                }
            }
        }
        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            consultarCategorias();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblDataValidade_Click(object sender, EventArgs e)
        {

        }

        private void chkDataValidade_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDataValidade.Checked)
            {
                dtpDataValidade.Enabled = true;
            }
            else
            {
                dtpDataValidade.Enabled = false;
                dtpDataValidade.Value = DateTime.Today;
            }
        }

        private void numUpPrecoCompra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
