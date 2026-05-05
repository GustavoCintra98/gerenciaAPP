namespace GerenciaAPP
{
    partial class frmConsultarFornecedores
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
            grbInformacoesBusca = new GroupBox();
            txtBuscarFornecedores = new TextBox();
            lblBuscar = new Label();
            dgvFornecedores = new DataGridView();
            ctxConsultarFornecedor = new ContextMenuStrip(components);
            alterarToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            grbInformacoesBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            ctxConsultarFornecedor.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(txtBuscarFornecedores);
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Location = new Point(12, 12);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(776, 75);
            grbInformacoesBusca.TabIndex = 0;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // txtBuscarFornecedores
            // 
            txtBuscarFornecedores.Location = new Point(6, 37);
            txtBuscarFornecedores.Name = "txtBuscarFornecedores";
            txtBuscarFornecedores.Size = new Size(402, 23);
            txtBuscarFornecedores.TabIndex = 1;
            txtBuscarFornecedores.TextChanged += txtBuscarFornecedores_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(323, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Informe o Nome, CNPJ, Fantasia ou Telefone do fornecedor:";
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.AllowUserToAddRows = false;
            dgvFornecedores.AllowUserToDeleteRows = false;
            dgvFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.ContextMenuStrip = ctxConsultarFornecedor;
            dgvFornecedores.Location = new Point(12, 93);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.ReadOnly = true;
            dgvFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedores.Size = new Size(776, 515);
            dgvFornecedores.TabIndex = 1;
            dgvFornecedores.CellContentClick += dgvFornecedores_CellContentClick;
            // 
            // ctxConsultarFornecedor
            // 
            ctxConsultarFornecedor.Items.AddRange(new ToolStripItem[] { alterarToolStripMenuItem, deletarToolStripMenuItem });
            ctxConsultarFornecedor.Name = "ctxConsultarFornecedor";
            ctxConsultarFornecedor.Size = new Size(112, 48);
            ctxConsultarFornecedor.Opening += contextMenuStrip1_Opening;
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(111, 22);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(111, 22);
            deletarToolStripMenuItem.Text = "Deletar";
            deletarToolStripMenuItem.Click += deletarToolStripMenuItem_Click;
            // 
            // frmConsultarFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(dgvFornecedores);
            Controls.Add(grbInformacoesBusca);
            Name = "frmConsultarFornecedores";
            Text = "GerenciaAPP - Consultar Fornecedores";
            Load += frmConsultarFornecedores_Load;
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ctxConsultarFornecedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesBusca;
        private Label lblBuscar;
        private TextBox txtBuscarFornecedores;
        private DataGridView dgvFornecedores;
        private ContextMenuStrip ctxConsultarFornecedor;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
    }
}