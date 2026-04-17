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
            ctxConsultarFornecedores = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            grbInformacoesBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            ctxConsultarFornecedores.SuspendLayout();
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
            dgvFornecedores.ContextMenuStrip = ctxConsultarFornecedores;
            dgvFornecedores.Location = new Point(12, 93);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.Size = new Size(776, 515);
            dgvFornecedores.TabIndex = 1;
            // 
            // ctxConsultarFornecedores
            // 
            ctxConsultarFornecedores.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, removerToolStripMenuItem });
            ctxConsultarFornecedores.Name = "ctxConsultarFornecedores";
            ctxConsultarFornecedores.Size = new Size(162, 48);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            editarToolStripMenuItem.Size = new Size(161, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.ShortcutKeys = Keys.Delete;
            removerToolStripMenuItem.Size = new Size(161, 22);
            removerToolStripMenuItem.Text = "Remover";
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
            ctxConsultarFornecedores.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesBusca;
        private Label lblBuscar;
        private TextBox txtBuscarFornecedores;
        private DataGridView dgvFornecedores;
        private ContextMenuStrip ctxConsultarFornecedores;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
    }
}