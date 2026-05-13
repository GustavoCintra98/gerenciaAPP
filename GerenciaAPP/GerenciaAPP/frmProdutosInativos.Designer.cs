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
            grpConsultarProdutosInativos = new GroupBox();
            txtConsultarProdutoInativo = new TextBox();
            lblBuscarProdutoInatvio = new Label();
            dgvConsultarProdutosInativos = new DataGridView();
            ctxRestaurarProdutoInativo = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            grpConsultarProdutosInativos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProdutosInativos).BeginInit();
            ctxRestaurarProdutoInativo.SuspendLayout();
            SuspendLayout();
            // 
            // grpConsultarProdutosInativos
            // 
            grpConsultarProdutosInativos.Controls.Add(txtConsultarProdutoInativo);
            grpConsultarProdutosInativos.Controls.Add(lblBuscarProdutoInatvio);
            grpConsultarProdutosInativos.Location = new Point(12, 12);
            grpConsultarProdutosInativos.Name = "grpConsultarProdutosInativos";
            grpConsultarProdutosInativos.Size = new Size(791, 109);
            grpConsultarProdutosInativos.TabIndex = 0;
            grpConsultarProdutosInativos.TabStop = false;
            grpConsultarProdutosInativos.Text = "Buscar Informação:";
            // 
            // txtConsultarProdutoInativo
            // 
            txtConsultarProdutoInativo.Location = new Point(6, 48);
            txtConsultarProdutoInativo.Name = "txtConsultarProdutoInativo";
            txtConsultarProdutoInativo.Size = new Size(520, 23);
            txtConsultarProdutoInativo.TabIndex = 1;
            txtConsultarProdutoInativo.TextChanged += txtConsultarProdutoInativo_TextChanged;
            // 
            // lblBuscarProdutoInatvio
            // 
            lblBuscarProdutoInatvio.AutoSize = true;
            lblBuscarProdutoInatvio.Location = new Point(0, 19);
            lblBuscarProdutoInatvio.Name = "lblBuscarProdutoInatvio";
            lblBuscarProdutoInatvio.Size = new Size(284, 15);
            lblBuscarProdutoInatvio.TabIndex = 0;
            lblBuscarProdutoInatvio.Text = "Informe o Nome, SKU, Código de Barras do Produto:";
            lblBuscarProdutoInatvio.Click += lblBuscarProdutoInatvio_Click;
            // 
            // dgvConsultarProdutosInativos
            // 
            dgvConsultarProdutosInativos.AllowUserToAddRows = false;
            dgvConsultarProdutosInativos.AllowUserToDeleteRows = false;
            dgvConsultarProdutosInativos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarProdutosInativos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarProdutosInativos.ContextMenuStrip = ctxRestaurarProdutoInativo;
            dgvConsultarProdutosInativos.Location = new Point(12, 127);
            dgvConsultarProdutosInativos.MultiSelect = false;
            dgvConsultarProdutosInativos.Name = "dgvConsultarProdutosInativos";
            dgvConsultarProdutosInativos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarProdutosInativos.Size = new Size(791, 418);
            dgvConsultarProdutosInativos.TabIndex = 1;
            // 
            // ctxRestaurarProdutoInativo
            // 
            ctxRestaurarProdutoInativo.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            ctxRestaurarProdutoInativo.Name = "ctxRestaurarProdutoInativo";
            ctxRestaurarProdutoInativo.Size = new Size(181, 48);
            ctxRestaurarProdutoInativo.Opening += contextMenuStrip1_Opening;
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
            ClientSize = new Size(815, 557);
            Controls.Add(dgvConsultarProdutosInativos);
            Controls.Add(grpConsultarProdutosInativos);
            Name = "frmConsultarProdutosInativos";
            Text = "GereciaAPP - Consultar Pordutos Inativos";
            Load += frmConsultarProdutosInativos_Load;
            grpConsultarProdutosInativos.ResumeLayout(false);
            grpConsultarProdutosInativos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarProdutosInativos).EndInit();
            ctxRestaurarProdutoInativo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpConsultarProdutosInativos;
        private Label lblBuscarProdutoInatvio;
        private TextBox txtConsultarProdutoInativo;
        private DataGridView dgvConsultarProdutosInativos;
        private ContextMenuStrip ctxRestaurarProdutoInativo;
        private ToolStripMenuItem restaurarToolStripMenuItem;
    }
}