namespace GerenciaAPP
{
    partial class frmConsultarCategoriasInativas
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
            dgvCategoriasInativas = new DataGridView();
            ctxCategoriasInativas = new ContextMenuStrip(components);
            restaurarToolStripMenuItem = new ToolStripMenuItem();
            txtBuscarCategoriasInativas = new TextBox();
            grbInformacoesBusca = new GroupBox();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriasInativas).BeginInit();
            ctxCategoriasInativas.SuspendLayout();
            grbInformacoesBusca.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategoriasInativas
            // 
            dgvCategoriasInativas.AllowUserToAddRows = false;
            dgvCategoriasInativas.AllowUserToDeleteRows = false;
            dgvCategoriasInativas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoriasInativas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriasInativas.ContextMenuStrip = ctxCategoriasInativas;
            dgvCategoriasInativas.Location = new Point(8, 93);
            dgvCategoriasInativas.MultiSelect = false;
            dgvCategoriasInativas.Name = "dgvCategoriasInativas";
            dgvCategoriasInativas.ReadOnly = true;
            dgvCategoriasInativas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoriasInativas.Size = new Size(546, 427);
            dgvCategoriasInativas.TabIndex = 3;
            // 
            // ctxCategoriasInativas
            // 
            ctxCategoriasInativas.Items.AddRange(new ToolStripItem[] { restaurarToolStripMenuItem });
            ctxCategoriasInativas.Name = "ctxCategoriasInativas";
            ctxCategoriasInativas.Size = new Size(181, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            restaurarToolStripMenuItem.Size = new Size(180, 22);
            restaurarToolStripMenuItem.Text = "Restaurar";
            restaurarToolStripMenuItem.Click += restaurarToolStripMenuItem_Click;
            // 
            // txtBuscarCategoriasInativas
            // 
            txtBuscarCategoriasInativas.Location = new Point(6, 37);
            txtBuscarCategoriasInativas.Name = "txtBuscarCategoriasInativas";
            txtBuscarCategoriasInativas.Size = new Size(534, 23);
            txtBuscarCategoriasInativas.TabIndex = 1;
            txtBuscarCategoriasInativas.TextChanged += txtBuscarCategoriasInativas_TextChanged;
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(txtBuscarCategoriasInativas);
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Location = new Point(8, 12);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(546, 75);
            grbInformacoesBusca.TabIndex = 2;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 19);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(234, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Informe o nome ou descrição da categoria:";
            // 
            // frmConsultarCategoriasInativas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 528);
            Controls.Add(dgvCategoriasInativas);
            Controls.Add(grbInformacoesBusca);
            Name = "frmConsultarCategoriasInativas";
            Text = "GerenciaAPP - Consultar Categorias Inativas";
            Load += frmConsultarCategoriasInativas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoriasInativas).EndInit();
            ctxCategoriasInativas.ResumeLayout(false);
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategoriasInativas;
        private TextBox txtBuscarCategoriasInativas;
        private GroupBox grbInformacoesBusca;
        private Label lblBuscar;
        private ContextMenuStrip ctxCategoriasInativas;
        private ToolStripMenuItem restaurarToolStripMenuItem;
    }
}