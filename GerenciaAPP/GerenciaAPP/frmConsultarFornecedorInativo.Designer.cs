namespace GerenciaAPP
{
    partial class frmConsultarFornecedorInativo
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
            grpBuscarFornecedorInativo = new GroupBox();
            lblConsultarFornecedorInativo = new Label();
            txtBuscarFornecedorInativo = new TextBox();
            dgvConsultarFornecedorInativo = new DataGridView();
            ctxRestaurarFornecedorInativo = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            grpBuscarFornecedorInativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarFornecedorInativo).BeginInit();
            ctxRestaurarFornecedorInativo.SuspendLayout();
            SuspendLayout();
            // 
            // grpBuscarFornecedorInativo
            // 
            grpBuscarFornecedorInativo.Controls.Add(lblConsultarFornecedorInativo);
            grpBuscarFornecedorInativo.Controls.Add(txtBuscarFornecedorInativo);
            grpBuscarFornecedorInativo.Location = new Point(12, 12);
            grpBuscarFornecedorInativo.Name = "grpBuscarFornecedorInativo";
            grpBuscarFornecedorInativo.Size = new Size(776, 95);
            grpBuscarFornecedorInativo.TabIndex = 0;
            grpBuscarFornecedorInativo.TabStop = false;
            grpBuscarFornecedorInativo.Text = "Buscar Informação:";
            // 
            // lblConsultarFornecedorInativo
            // 
            lblConsultarFornecedorInativo.AutoSize = true;
            lblConsultarFornecedorInativo.Location = new Point(6, 19);
            lblConsultarFornecedorInativo.Name = "lblConsultarFornecedorInativo";
            lblConsultarFornecedorInativo.Size = new Size(323, 15);
            lblConsultarFornecedorInativo.TabIndex = 1;
            lblConsultarFornecedorInativo.Text = "Informe o Nome, CNPJ, Fantasia ou Telefone do fornecedor:";
            lblConsultarFornecedorInativo.Click += label1_Click;
            // 
            // txtBuscarFornecedorInativo
            // 
            txtBuscarFornecedorInativo.Location = new Point(6, 48);
            txtBuscarFornecedorInativo.Name = "txtBuscarFornecedorInativo";
            txtBuscarFornecedorInativo.Size = new Size(725, 23);
            txtBuscarFornecedorInativo.TabIndex = 0;
            txtBuscarFornecedorInativo.TextChanged += txtBuscarFornecedorInativo_TextChanged;
            // 
            // dgvConsultarFornecedorInativo
            // 
            dgvConsultarFornecedorInativo.AllowUserToAddRows = false;
            dgvConsultarFornecedorInativo.AllowUserToDeleteRows = false;
            dgvConsultarFornecedorInativo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarFornecedorInativo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarFornecedorInativo.ContextMenuStrip = ctxRestaurarFornecedorInativo;
            dgvConsultarFornecedorInativo.Location = new Point(12, 113);
            dgvConsultarFornecedorInativo.MultiSelect = false;
            dgvConsultarFornecedorInativo.Name = "dgvConsultarFornecedorInativo";
            dgvConsultarFornecedorInativo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarFornecedorInativo.Size = new Size(776, 517);
            dgvConsultarFornecedorInativo.TabIndex = 1;
            // 
            // ctxRestaurarFornecedorInativo
            // 
            ctxRestaurarFornecedorInativo.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            ctxRestaurarFornecedorInativo.Name = "ctxRestaurarFornecedorInativo";
            ctxRestaurarFornecedorInativo.Size = new Size(181, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(180, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // frmConsultarFornecedorInativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 642);
            Controls.Add(dgvConsultarFornecedorInativo);
            Controls.Add(grpBuscarFornecedorInativo);
            Name = "frmConsultarFornecedorInativo";
            Text = "GerenciaAPP - Consultar Fornecedores Inativos";
            Load += frmConsultarFornecedorInativo_Load;
            grpBuscarFornecedorInativo.ResumeLayout(false);
            grpBuscarFornecedorInativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarFornecedorInativo).EndInit();
            ctxRestaurarFornecedorInativo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBuscarFornecedorInativo;
        private TextBox txtBuscarFornecedorInativo;
        private Label lblConsultarFornecedorInativo;
        private DataGridView dgvConsultarFornecedorInativo;
        private ContextMenuStrip ctxRestaurarFornecedorInativo;
        private ToolStripMenuItem restaurarToolStripMenuItem;
    }
}