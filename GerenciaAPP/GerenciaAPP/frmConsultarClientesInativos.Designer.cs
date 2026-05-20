namespace GerenciaAPP
{
    partial class frmConsultarClientesInativos
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
            txtBuscarClientesInativos = new TextBox();
            lblBuscar = new Label();
            dgvClientesInativos = new DataGridView();
            ctxConsultarClientesInativos = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            grbInformacoesBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientesInativos).BeginInit();
            ctxConsultarClientesInativos.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(txtBuscarClientesInativos);
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Location = new Point(12, 12);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(776, 76);
            grbInformacoesBusca.TabIndex = 2;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // txtBuscarClientesInativos
            // 
            txtBuscarClientesInativos.Location = new Point(6, 37);
            txtBuscarClientesInativos.Name = "txtBuscarClientesInativos";
            txtBuscarClientesInativos.Size = new Size(450, 23);
            txtBuscarClientesInativos.TabIndex = 2;
            txtBuscarClientesInativos.TextChanged += txtBuscarClientesInativos_TextChanged;
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
            // dgvClientesInativos
            // 
            dgvClientesInativos.AllowUserToAddRows = false;
            dgvClientesInativos.AllowUserToDeleteRows = false;
            dgvClientesInativos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientesInativos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientesInativos.ContextMenuStrip = ctxConsultarClientesInativos;
            dgvClientesInativos.Location = new Point(12, 94);
            dgvClientesInativos.MultiSelect = false;
            dgvClientesInativos.Name = "dgvClientesInativos";
            dgvClientesInativos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientesInativos.Size = new Size(775, 512);
            dgvClientesInativos.TabIndex = 3;
            // 
            // ctxConsultarClientesInativos
            // 
            ctxConsultarClientesInativos.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            ctxConsultarClientesInativos.Name = "ctxConsultarClientesInativos";
            ctxConsultarClientesInativos.Size = new Size(181, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(180, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // frmConsultarClientesInativos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 612);
            Controls.Add(grbInformacoesBusca);
            Controls.Add(dgvClientesInativos);
            Name = "frmConsultarClientesInativos";
            Text = "GerenciaAPP - Consultar Clientes Inativos";
            Load += frmConsultarClientesInativos_Load;
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientesInativos).EndInit();
            ctxConsultarClientesInativos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesBusca;
        private TextBox txtBuscarClientesInativos;
        private Label lblBuscar;
        private DataGridView dgvClientesInativos;
        private ContextMenuStrip ctxConsultarClientesInativos;
        private ToolStripMenuItem restaurarToolStripMenuItem;
    }
}