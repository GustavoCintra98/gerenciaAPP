namespace GerenciaAPP
{
    partial class frmConsultarClientes
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
            txtBuscarClientes = new TextBox();
            lblBuscar = new Label();
            dgvClientes = new DataGridView();
            ctxConsultarClientes = new ContextMenuStrip(components);
            alterarToolStripMenuItem = new ToolStripMenuItem();
            deletarToolStripMenuItem = new ToolStripMenuItem();
            grbInformacoesBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ctxConsultarClientes.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(txtBuscarClientes);
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Location = new Point(12, 12);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(776, 76);
            grbInformacoesBusca.TabIndex = 0;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // txtBuscarClientes
            // 
            txtBuscarClientes.Location = new Point(6, 37);
            txtBuscarClientes.Name = "txtBuscarClientes";
            txtBuscarClientes.Size = new Size(450, 23);
            txtBuscarClientes.TabIndex = 2;
            txtBuscarClientes.TextChanged += txtBuscarClientes_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(245, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Informe o Nome, CPF ou Telefone do cliente:";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.ContextMenuStrip = ctxConsultarClientes;
            dgvClientes.Location = new Point(12, 94);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(775, 512);
            dgvClientes.TabIndex = 1;
            // 
            // ctxConsultarClientes
            // 
            ctxConsultarClientes.Items.AddRange(new ToolStripItem[] { alterarToolStripMenuItem, deletarToolStripMenuItem });
            ctxConsultarClientes.Name = "ctxConsultarClientes";
            ctxConsultarClientes.Size = new Size(181, 70);
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(180, 22);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // deletarToolStripMenuItem
            // 
            deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            deletarToolStripMenuItem.Size = new Size(180, 22);
            deletarToolStripMenuItem.Text = "Deletar";
            deletarToolStripMenuItem.Click += deletarToolStripMenuItem_Click_1;
            // 
            // frmConsultarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 618);
            Controls.Add(dgvClientes);
            Controls.Add(grbInformacoesBusca);
            Name = "frmConsultarClientes";
            Text = "GerenciaAPP - Consultar Clientes";
            Load += frmConsultarClientes_Load;
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ctxConsultarClientes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesBusca;
        private Label lblBuscar;
        private TextBox txtBuscarClientes;
        private DataGridView dgvClientes;
        private ContextMenuStrip ctxConsultarClientes;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem deletarToolStripMenuItem;
    }
}