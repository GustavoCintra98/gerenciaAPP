namespace GerenciaAPP
{
    partial class frmConsultarProdutosInativos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvProdutos = new DataGridView();
            txtBuscarProdutos = new TextBox();
            grbInformacoesBusca = new GroupBox();
            lblBuscar = new Label();
            ctxConsultarProdutosInativos = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            grbInformacoesBusca.SuspendLayout();
            ctxConsultarProdutosInativos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.ContextMenuStrip = ctxConsultarProdutosInativos;
            dgvProdutos.Location = new Point(9, 93);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(882, 523);
            dgvProdutos.TabIndex = 3;
            // 
            // txtBuscarProdutos
            // 
            txtBuscarProdutos.Location = new Point(6, 39);
            txtBuscarProdutos.Name = "txtBuscarProdutos";
            txtBuscarProdutos.Size = new Size(413, 23);
            txtBuscarProdutos.TabIndex = 0;
            txtBuscarProdutos.TextChanged += txtBuscarProdutos_TextChanged;
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Controls.Add(txtBuscarProdutos);
            grbInformacoesBusca.Location = new Point(9, 4);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(882, 83);
            grbInformacoesBusca.TabIndex = 2;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 21);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(284, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Informe o Nome, SKU, Código de Barras do Produto:";
            // 
            // ctxConsultarProdutosInativos
            // 
            ctxConsultarProdutosInativos.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            ctxConsultarProdutosInativos.Name = "contextMenuStrip1";
            ctxConsultarProdutosInativos.Size = new Size(181, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(180, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // frmConsultarProdutosInativos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 628);
            Controls.Add(dgvProdutos);
            Controls.Add(grbInformacoesBusca);
            Name = "frmConsultarProdutosInativos";
            Text = "GerenciaAPP - Consultar Produtos Inativos";
            Load += frmConsultarProdutosInativos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ctxConsultarProdutosInativos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProdutos;
        private TextBox txtBuscarProdutos;
        private GroupBox grbInformacoesBusca;
        private Label lblBuscar;
        private ContextMenuStrip ctxConsultarProdutosInativos;
        private ToolStripMenuItem restaurarToolStripMenuItem;
    }
}