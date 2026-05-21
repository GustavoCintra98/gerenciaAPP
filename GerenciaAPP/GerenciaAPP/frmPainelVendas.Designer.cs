namespace GerenciaAPP
{
    partial class frmPainelVendas
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
            panel1 = new Panel();
            lblRetornoEstoque = new Label();
            lblEstoque = new Label();
            lblRetornoValor = new Label();
            lblValor = new Label();
            lblRetornoProduto = new Label();
            lblProduto = new Label();
            pictureBox1 = new PictureBox();
            btnBuscarProduto = new Button();
            lblCodigoBarras = new Label();
            txtCodigoBarras = new TextBox();
            panel2 = new Panel();
            lblItensVenda = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            btnNovaVenda = new Button();
            btnLimparVenda = new Button();
            btnRemoverItem = new Button();
            panel4 = new Panel();
            panel8 = new Panel();
            btnBoleto = new Button();
            btnPIX = new Button();
            btnCartao = new Button();
            btnDinheiro = new Button();
            lblFormaPagamento = new Label();
            panel7 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            lblDesconto = new Label();
            lblSubTotal = new Label();
            lblTotais = new Label();
            panel5 = new Panel();
            btnFinalizarVenda = new Button();
            btnAplicarDesconto = new Button();
            btnConsultarPreco = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(lblRetornoEstoque);
            panel1.Controls.Add(lblEstoque);
            panel1.Controls.Add(lblRetornoValor);
            panel1.Controls.Add(lblValor);
            panel1.Controls.Add(lblRetornoProduto);
            panel1.Controls.Add(lblProduto);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBuscarProduto);
            panel1.Controls.Add(lblCodigoBarras);
            panel1.Controls.Add(txtCodigoBarras);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 236);
            panel1.TabIndex = 0;
            // 
            // lblRetornoEstoque
            // 
            lblRetornoEstoque.AutoSize = true;
            lblRetornoEstoque.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRetornoEstoque.Location = new Point(314, 168);
            lblRetornoEstoque.Name = "lblRetornoEstoque";
            lblRetornoEstoque.Size = new Size(40, 15);
            lblRetornoEstoque.TabIndex = 9;
            lblRetornoEstoque.Text = "label7";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstoque.Location = new Point(314, 141);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(63, 15);
            lblEstoque.TabIndex = 8;
            lblEstoque.Text = "ESTOQUE:";
            // 
            // lblRetornoValor
            // 
            lblRetornoValor.AutoSize = true;
            lblRetornoValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRetornoValor.ForeColor = Color.Green;
            lblRetornoValor.Location = new Point(146, 168);
            lblRetornoValor.Name = "lblRetornoValor";
            lblRetornoValor.Size = new Size(40, 15);
            lblRetornoValor.TabIndex = 7;
            lblRetornoValor.Text = "label5";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValor.Location = new Point(146, 141);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(48, 15);
            lblValor.TabIndex = 6;
            lblValor.Text = "VALOR:";
            // 
            // lblRetornoProduto
            // 
            lblRetornoProduto.AutoSize = true;
            lblRetornoProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRetornoProduto.Location = new Point(146, 104);
            lblRetornoProduto.Name = "lblRetornoProduto";
            lblRetornoProduto.Size = new Size(40, 15);
            lblRetornoProduto.TabIndex = 5;
            lblRetornoProduto.Text = "label3";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProduto.Location = new Point(146, 79);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(68, 15);
            lblProduto.TabIndex = 4;
            lblProduto.Text = "PRODUTO:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 120);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.Location = new Point(402, 38);
            btnBuscarProduto.Name = "btnBuscarProduto";
            btnBuscarProduto.Size = new Size(112, 35);
            btnBuscarProduto.TabIndex = 2;
            btnBuscarProduto.Text = "Buscar";
            btnBuscarProduto.UseVisualStyleBackColor = true;
            // 
            // lblCodigoBarras
            // 
            lblCodigoBarras.AutoSize = true;
            lblCodigoBarras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigoBarras.Location = new Point(21, 20);
            lblCodigoBarras.Name = "lblCodigoBarras";
            lblCodigoBarras.Size = new Size(125, 15);
            lblCodigoBarras.TabIndex = 1;
            lblCodigoBarras.Text = "CÓDIGO DE BARRAS:";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(21, 38);
            txtCodigoBarras.Multiline = true;
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(375, 35);
            txtCodigoBarras.TabIndex = 0;
            txtCodigoBarras.TextChanged += txtCodigoBarras_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(lblItensVenda);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(12, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 332);
            panel2.TabIndex = 1;
            // 
            // lblItensVenda
            // 
            lblItensVenda.AutoSize = true;
            lblItensVenda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItensVenda.Location = new Point(21, 9);
            lblItensVenda.Name = "lblItensVenda";
            lblItensVenda.Size = new Size(148, 25);
            lblItensVenda.TabIndex = 1;
            lblItensVenda.Text = "Itens da Venda:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(493, 293);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(btnNovaVenda);
            panel3.Controls.Add(btnLimparVenda);
            panel3.Controls.Add(btnRemoverItem);
            panel3.Location = new Point(12, 592);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 102);
            panel3.TabIndex = 1;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.BackColor = Color.FromArgb(128, 128, 255);
            btnNovaVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovaVenda.Location = new Point(396, 20);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(118, 50);
            btnNovaVenda.TabIndex = 2;
            btnNovaVenda.Text = "NOVA VENDA";
            btnNovaVenda.UseVisualStyleBackColor = false;
            // 
            // btnLimparVenda
            // 
            btnLimparVenda.BackColor = Color.FromArgb(255, 192, 128);
            btnLimparVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparVenda.Location = new Point(203, 20);
            btnLimparVenda.Name = "btnLimparVenda";
            btnLimparVenda.Size = new Size(118, 50);
            btnLimparVenda.TabIndex = 1;
            btnLimparVenda.Text = "LIMPAR VENDA";
            btnLimparVenda.UseVisualStyleBackColor = false;
            // 
            // btnRemoverItem
            // 
            btnRemoverItem.BackColor = Color.FromArgb(255, 128, 128);
            btnRemoverItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoverItem.Location = new Point(21, 20);
            btnRemoverItem.Name = "btnRemoverItem";
            btnRemoverItem.Size = new Size(118, 50);
            btnRemoverItem.TabIndex = 0;
            btnRemoverItem.Text = "REMOVER ITEM";
            btnRemoverItem.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(lblTotais);
            panel4.Location = new Point(547, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(576, 574);
            panel4.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnBoleto);
            panel8.Controls.Add(btnPIX);
            panel8.Controls.Add(btnCartao);
            panel8.Controls.Add(btnDinheiro);
            panel8.Controls.Add(lblFormaPagamento);
            panel8.Location = new Point(12, 180);
            panel8.Name = "panel8";
            panel8.Size = new Size(558, 176);
            panel8.TabIndex = 6;
            // 
            // btnBoleto
            // 
            btnBoleto.Location = new Point(378, 62);
            btnBoleto.Name = "btnBoleto";
            btnBoleto.Size = new Size(97, 66);
            btnBoleto.TabIndex = 8;
            btnBoleto.Text = "Boleto";
            btnBoleto.UseVisualStyleBackColor = true;
            // 
            // btnPIX
            // 
            btnPIX.Location = new Point(275, 62);
            btnPIX.Name = "btnPIX";
            btnPIX.Size = new Size(97, 66);
            btnPIX.TabIndex = 7;
            btnPIX.Text = "PIX";
            btnPIX.UseVisualStyleBackColor = true;
            // 
            // btnCartao
            // 
            btnCartao.Location = new Point(172, 62);
            btnCartao.Name = "btnCartao";
            btnCartao.Size = new Size(97, 66);
            btnCartao.TabIndex = 6;
            btnCartao.Text = "Cartão";
            btnCartao.UseVisualStyleBackColor = true;
            // 
            // btnDinheiro
            // 
            btnDinheiro.Location = new Point(69, 62);
            btnDinheiro.Name = "btnDinheiro";
            btnDinheiro.Size = new Size(97, 66);
            btnDinheiro.TabIndex = 5;
            btnDinheiro.Text = "Dinheiro";
            btnDinheiro.UseVisualStyleBackColor = true;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPagamento.Location = new Point(3, 2);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(164, 17);
            lblFormaPagamento.TabIndex = 4;
            lblFormaPagamento.Text = "FORMA DE PAGAMENTO:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Location = new Point(12, 125);
            panel7.Name = "panel7";
            panel7.Size = new Size(558, 49);
            panel7.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 4;
            label1.Text = "TOTAL:";
            // 
            // panel6
            // 
            panel6.Controls.Add(lblDesconto);
            panel6.Controls.Add(lblSubTotal);
            panel6.Location = new Point(12, 51);
            panel6.Name = "panel6";
            panel6.Size = new Size(558, 68);
            panel6.TabIndex = 4;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesconto.ForeColor = Color.ForestGreen;
            lblDesconto.Location = new Point(3, 37);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(78, 17);
            lblDesconto.TabIndex = 4;
            lblDesconto.Text = "DESCONTO";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(3, 6);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(72, 17);
            lblSubTotal.TabIndex = 3;
            lblSubTotal.Text = "SUBTOTAL";
            // 
            // lblTotais
            // 
            lblTotais.AutoSize = true;
            lblTotais.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotais.Location = new Point(15, 20);
            lblTotais.Name = "lblTotais";
            lblTotais.Size = new Size(201, 25);
            lblTotais.TabIndex = 0;
            lblTotais.Text = "VALORES DA VENDA:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Window;
            panel5.Controls.Add(btnFinalizarVenda);
            panel5.Controls.Add(btnAplicarDesconto);
            panel5.Controls.Add(btnConsultarPreco);
            panel5.Location = new Point(547, 592);
            panel5.Name = "panel5";
            panel5.Size = new Size(576, 102);
            panel5.TabIndex = 2;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.FromArgb(192, 255, 192);
            btnFinalizarVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarVenda.Location = new Point(392, 20);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(118, 50);
            btnFinalizarVenda.TabIndex = 4;
            btnFinalizarVenda.Text = "FINALIZAR VENDA";
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            // 
            // btnAplicarDesconto
            // 
            btnAplicarDesconto.BackColor = Color.FromArgb(128, 255, 255);
            btnAplicarDesconto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAplicarDesconto.Location = new Point(203, 20);
            btnAplicarDesconto.Name = "btnAplicarDesconto";
            btnAplicarDesconto.Size = new Size(118, 50);
            btnAplicarDesconto.TabIndex = 3;
            btnAplicarDesconto.Text = "APLICAR DESCONTO";
            btnAplicarDesconto.UseVisualStyleBackColor = false;
            // 
            // btnConsultarPreco
            // 
            btnConsultarPreco.BackColor = Color.FromArgb(255, 255, 128);
            btnConsultarPreco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarPreco.Location = new Point(18, 20);
            btnConsultarPreco.Name = "btnConsultarPreco";
            btnConsultarPreco.Size = new Size(118, 50);
            btnConsultarPreco.TabIndex = 2;
            btnConsultarPreco.Text = "CONSULTAR PREÇO";
            btnConsultarPreco.UseVisualStyleBackColor = false;
            // 
            // frmPainelVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 699);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmPainelVendas";
            Text = "GerenciaAPP - Nova Venda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Label lblCodigoBarras;
        private TextBox txtCodigoBarras;
        private Button btnBuscarProduto;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private PictureBox pictureBox1;
        private Label lblRetornoValor;
        private Label lblValor;
        private Label lblRetornoProduto;
        private Label lblProduto;
        private Label lblRetornoEstoque;
        private Label lblEstoque;
        private DataGridView dataGridView1;
        private Label lblItensVenda;
        private Button btnRemoverItem;
        private Button btnNovaVenda;
        private Button btnLimparVenda;
        private Label lblTotais;
        private Panel panel8;
        private Panel panel7;
        private Label label1;
        private Panel panel6;
        private Label lblDesconto;
        private Label lblSubTotal;
        private Label lblFormaPagamento;
        private Button btnBoleto;
        private Button btnPIX;
        private Button btnCartao;
        private Button btnDinheiro;
        private Button btnFinalizarVenda;
        private Button btnAplicarDesconto;
        private Button btnConsultarPreco;
    }
}