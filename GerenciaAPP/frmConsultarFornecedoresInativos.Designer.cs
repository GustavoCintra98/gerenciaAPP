namespace GerenciaAPP
{
    partial class frmConsultarFornecedoresInativos
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
            txtBuscarFornecedoresInativos = new TextBox();
            lblBuscar = new Label();
            dgvFornecedoresInativos = new DataGridView();
            ctxConsultarFornecedoresInativos = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            grbInformacoesBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedoresInativos).BeginInit();
            ctxConsultarFornecedoresInativos.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(txtBuscarFornecedoresInativos);
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Location = new Point(12, 14);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(776, 75);
            grbInformacoesBusca.TabIndex = 2;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // txtBuscarFornecedoresInativos
            // 
            txtBuscarFornecedoresInativos.Location = new Point(6, 37);
            txtBuscarFornecedoresInativos.Name = "txtBuscarFornecedoresInativos";
            txtBuscarFornecedoresInativos.Size = new Size(402, 23);
            txtBuscarFornecedoresInativos.TabIndex = 1;
            txtBuscarFornecedoresInativos.TextChanged += txtBuscarFornecedores_TextChanged;
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
            // dgvFornecedoresInativos
            // 
            dgvFornecedoresInativos.AllowUserToAddRows = false;
            dgvFornecedoresInativos.AllowUserToDeleteRows = false;
            dgvFornecedoresInativos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedoresInativos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedoresInativos.ContextMenuStrip = ctxConsultarFornecedoresInativos;
            dgvFornecedoresInativos.Location = new Point(12, 95);
            dgvFornecedoresInativos.Name = "dgvFornecedoresInativos";
            dgvFornecedoresInativos.ReadOnly = true;
            dgvFornecedoresInativos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedoresInativos.Size = new Size(776, 515);
            dgvFornecedoresInativos.TabIndex = 3;
            // 
            // ctxConsultarFornecedoresInativos
            // 
            ctxConsultarFornecedoresInativos.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            ctxConsultarFornecedoresInativos.Name = "ctxConsultarFornecedoresInativos";
            ctxConsultarFornecedoresInativos.Size = new Size(181, 48);
            ctxConsultarFornecedoresInativos.Opening += ctxConsultarFornecedoresInativos_Opening;
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(180, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // frmConsultarFornecedoresInativos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 615);
            Controls.Add(grbInformacoesBusca);
            Controls.Add(dgvFornecedoresInativos);
            Name = "frmConsultarFornecedoresInativos";
            Text = "GerenciaAPP - Consultar Fornecedores Inativos";
            Load += frmConsultarFornecedoresInativos_Load;
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedoresInativos).EndInit();
            ctxConsultarFornecedoresInativos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesBusca;
        private TextBox txtBuscarFornecedoresInativos;
        private Label lblBuscar;
        private DataGridView dgvFornecedoresInativos;
        private ContextMenuStrip ctxConsultarFornecedoresInativos;
        private ToolStripMenuItem restaurarToolStripMenuItem;
    }
}