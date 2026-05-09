namespace GerenciaAPP
{
    partial class frmConsultarClienteInativo
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
            grpConsultarClienteInativo = new GroupBox();
            txtConsultarClienteInativo = new TextBox();
            lblConsultarClienteInativo = new Label();
            dgvConsultarClienteInativo = new DataGridView();
            ctxRestaurarClienteInativo = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            grpConsultarClienteInativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClienteInativo).BeginInit();
            ctxRestaurarClienteInativo.SuspendLayout();
            SuspendLayout();
            // 
            // grpConsultarClienteInativo
            // 
            grpConsultarClienteInativo.Controls.Add(txtConsultarClienteInativo);
            grpConsultarClienteInativo.Controls.Add(lblConsultarClienteInativo);
            grpConsultarClienteInativo.Location = new Point(12, 12);
            grpConsultarClienteInativo.Name = "grpConsultarClienteInativo";
            grpConsultarClienteInativo.Size = new Size(787, 90);
            grpConsultarClienteInativo.TabIndex = 0;
            grpConsultarClienteInativo.TabStop = false;
            grpConsultarClienteInativo.Text = "Informações de Busca:";
            // 
            // txtConsultarClienteInativo
            // 
            txtConsultarClienteInativo.Location = new Point(6, 48);
            txtConsultarClienteInativo.Name = "txtConsultarClienteInativo";
            txtConsultarClienteInativo.Size = new Size(696, 23);
            txtConsultarClienteInativo.TabIndex = 1;
            txtConsultarClienteInativo.TextChanged += txtConsultarClienteInativo_TextChanged;
            // 
            // lblConsultarClienteInativo
            // 
            lblConsultarClienteInativo.AutoSize = true;
            lblConsultarClienteInativo.Location = new Point(6, 19);
            lblConsultarClienteInativo.Name = "lblConsultarClienteInativo";
            lblConsultarClienteInativo.Size = new Size(245, 15);
            lblConsultarClienteInativo.TabIndex = 0;
            lblConsultarClienteInativo.Text = "Informe o Nome, CPF ou Telefone do cliente:";
            // 
            // dgvConsultarClienteInativo
            // 
            dgvConsultarClienteInativo.AllowUserToAddRows = false;
            dgvConsultarClienteInativo.AllowUserToDeleteRows = false;
            dgvConsultarClienteInativo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarClienteInativo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarClienteInativo.ContextMenuStrip = ctxRestaurarClienteInativo;
            dgvConsultarClienteInativo.Location = new Point(12, 108);
            dgvConsultarClienteInativo.MultiSelect = false;
            dgvConsultarClienteInativo.Name = "dgvConsultarClienteInativo";
            dgvConsultarClienteInativo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarClienteInativo.Size = new Size(787, 476);
            dgvConsultarClienteInativo.TabIndex = 1;
            // 
            // ctxRestaurarClienteInativo
            // 
            ctxRestaurarClienteInativo.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            ctxRestaurarClienteInativo.Name = "ctxRestaurarClienteInativo";
            ctxRestaurarClienteInativo.Size = new Size(124, 26);
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(123, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // frmConsultarClienteInativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 596);
            Controls.Add(dgvConsultarClienteInativo);
            Controls.Add(grpConsultarClienteInativo);
            Name = "frmConsultarClienteInativo";
            Text = "Gerencia App - Consultar Clientes Inativos";
            Load += frmConsultarClienteInativo_Load;
            grpConsultarClienteInativo.ResumeLayout(false);
            grpConsultarClienteInativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarClienteInativo).EndInit();
            ctxRestaurarClienteInativo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpConsultarClienteInativo;
        private Label lblConsultarClienteInativo;
        private TextBox txtConsultarClienteInativo;
        private DataGridView dgvConsultarClienteInativo;
        private ContextMenuStrip ctxRestaurarClienteInativo;
        private ToolStripMenuItem restaurarToolStripMenuItem;
    }
}