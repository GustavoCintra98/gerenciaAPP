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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCategorias frmCadCategorias = new frmCadCategorias();

            frmCadCategorias.ShowDialog();


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadClientes frmCadClientes = new frmCadClientes();
            frmCadClientes.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedores frmCadFornecedores = new frmCadFornecedores();
            frmCadFornecedores.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmCadProdutos = new frmCadProdutos();
            frmCadProdutos.ShowDialog();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarCategorias frmConsultarCategorias = new frmConsultarCategorias();
            frmConsultarCategorias.Show();
        }

        private void categoriasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmConsultarCategorias frmConsultarCategorias = new frmConsultarCategorias();
            frmConsultarCategorias.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarClientes frmConsultarClientes = new frmConsultarClientes();
            frmConsultarClientes.Show();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarFornecedores frmConsultarFornecedores = new frmConsultarFornecedores();
            frmConsultarFornecedores.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos frmConsultarProdutos = new frmConsultarProdutos();
            frmConsultarProdutos.Show();
        }

        private void categoriasToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
