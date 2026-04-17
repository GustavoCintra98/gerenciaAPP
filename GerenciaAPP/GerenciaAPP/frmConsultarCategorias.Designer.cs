namespace GerenciaAPP
{
    partial class frmConsultarCategorias
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
            txtBuscarCategorias = new TextBox();
            lblBuscar = new Label();
            dgvCategorias = new DataGridView();
            ctxConsultarCategorias = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            grbInformacoesBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ctxConsultarCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(txtBuscarCategorias);
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Location = new Point(12, 12);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(546, 75);
            grbInformacoesBusca.TabIndex = 0;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // txtBuscarCategorias
            // 
            txtBuscarCategorias.Location = new Point(6, 37);
            txtBuscarCategorias.Name = "txtBuscarCategorias";
            txtBuscarCategorias.Size = new Size(534, 23);
            txtBuscarCategorias.TabIndex = 1;
            txtBuscarCategorias.TextChanged += txtBuscarCategorias_TextChanged;
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
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.ContextMenuStrip = ctxConsultarCategorias;
            dgvCategorias.Location = new Point(12, 93);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.Size = new Size(546, 427);
            dgvCategorias.TabIndex = 1;
            // 
            // ctxConsultarCategorias
            // 
            ctxConsultarCategorias.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, removerToolStripMenuItem });
            ctxConsultarCategorias.Name = "ctxConsultarCategorias";
            ctxConsultarCategorias.Size = new Size(122, 48);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(121, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(121, 22);
            removerToolStripMenuItem.Text = "Remover";
            // 
            // frmConsultarCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 534);
            Controls.Add(dgvCategorias);
            Controls.Add(grbInformacoesBusca);
            Name = "frmConsultarCategorias";
            Text = "GerenciaAPP - Consultar Categorias";
            Load += frmConsultarCategorias_Load;
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ctxConsultarCategorias.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesBusca;
        private Label lblBuscar;
        private TextBox txtBuscarCategorias;
        private DataGridView dgvCategorias;
        private ContextMenuStrip ctxConsultarCategorias;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
    }
}