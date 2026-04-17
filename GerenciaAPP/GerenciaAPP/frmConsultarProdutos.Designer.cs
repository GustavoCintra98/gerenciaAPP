namespace GerenciaAPP
{
    partial class frmConsultarProdutos
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
            grbInformacoesBusca = new GroupBox();
            lblBuscar = new Label();
            txtBuscarProdutos = new TextBox();
            dgvProdutos = new DataGridView();
            grbInformacoesBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Controls.Add(txtBuscarProdutos);
            grbInformacoesBusca.Location = new Point(12, 12);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(882, 98);
            grbInformacoesBusca.TabIndex = 0;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 21);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(284, 15);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Informe o Nome, SKU, Código de Barras do Produto:";
            // 
            // txtBuscarProdutos
            // 
            txtBuscarProdutos.Location = new Point(6, 39);
            txtBuscarProdutos.Name = "txtBuscarProdutos";
            txtBuscarProdutos.Size = new Size(413, 23);
            txtBuscarProdutos.TabIndex = 0;
            txtBuscarProdutos.TextChanged += txtBuscarProdutos_TextChanged;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(12, 116);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(882, 510);
            dgvProdutos.TabIndex = 1;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            // 
            // frmConsultarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 638);
            Controls.Add(dgvProdutos);
            Controls.Add(grbInformacoesBusca);
            Name = "frmConsultarProdutos";
            Text = "GerenciaAPP - Consultar Produtos";
            Load += frmConsultarProdutos_Load;
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesBusca;
        private Label lblBuscar;
        private TextBox txtBuscarProdutos;
        private DataGridView dgvProdutos;
    }
}