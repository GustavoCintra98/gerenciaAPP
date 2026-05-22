namespace GerenciaAPP
{
    partial class frmConsultarFornecedorProdutos
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
            txtBuscarFornecedor = new TextBox();
            lblBuscar = new Label();
            dgvFornecedoresProdutos = new DataGridView();
            grbInformacoesBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedoresProdutos).BeginInit();
            SuspendLayout();
            // 
            // grbInformacoesBusca
            // 
            grbInformacoesBusca.Controls.Add(txtBuscarFornecedor);
            grbInformacoesBusca.Controls.Add(lblBuscar);
            grbInformacoesBusca.Location = new Point(12, 12);
            grbInformacoesBusca.Name = "grbInformacoesBusca";
            grbInformacoesBusca.Size = new Size(539, 81);
            grbInformacoesBusca.TabIndex = 0;
            grbInformacoesBusca.TabStop = false;
            grbInformacoesBusca.Text = "Informações de Busca:";
            // 
            // txtBuscarFornecedor
            // 
            txtBuscarFornecedor.Location = new Point(6, 46);
            txtBuscarFornecedor.Name = "txtBuscarFornecedor";
            txtBuscarFornecedor.Size = new Size(526, 23);
            txtBuscarFornecedor.TabIndex = 1;
            txtBuscarFornecedor.TextChanged += txtBuscarFornecedor_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(6, 28);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(323, 15);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Informe o Nome, CNPJ, Fantasia ou Telefone do fornecedor:";
            // 
            // dgvFornecedoresProdutos
            // 
            dgvFornecedoresProdutos.AllowUserToAddRows = false;
            dgvFornecedoresProdutos.AllowUserToDeleteRows = false;
            dgvFornecedoresProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedoresProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedoresProdutos.EditMode = DataGridViewEditMode.EditOnF2;
            dgvFornecedoresProdutos.Location = new Point(12, 99);
            dgvFornecedoresProdutos.Name = "dgvFornecedoresProdutos";
            dgvFornecedoresProdutos.ReadOnly = true;
            dgvFornecedoresProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedoresProdutos.Size = new Size(539, 436);
            dgvFornecedoresProdutos.TabIndex = 1;
            dgvFornecedoresProdutos.CellContentClick += dgvFornecedoresProdutos_CellContentClick;
            dgvFornecedoresProdutos.CellDoubleClick += dgvFornecedoresProdutos_CellDoubleClick;
            dgvFornecedoresProdutos.DoubleClick += dgvFornecedoresProdutos_DoubleClick;
            // 
            // frmConsultarFornecedorProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 545);
            Controls.Add(dgvFornecedoresProdutos);
            Controls.Add(grbInformacoesBusca);
            Name = "frmConsultarFornecedorProdutos";
            Text = "GerenciaAPP - Selecionar Fornecedor";
            Load += frmConsultarFornecedorProdutos_Load;
            grbInformacoesBusca.ResumeLayout(false);
            grbInformacoesBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedoresProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesBusca;
        private Label lblBuscar;
        private TextBox txtBuscarFornecedor;
        private DataGridView dgvFornecedoresProdutos;
    }
}