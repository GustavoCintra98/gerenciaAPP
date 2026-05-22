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
            components = new System.ComponentModel.Container();
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
            dgvItensVenda = new DataGridView();
            panel3 = new Panel();
            btnNovaVenda = new Button();
            btnLimparVenda = new Button();
            btnRemoverItem = new Button();
            panel4 = new Panel();
            panel8 = new Panel();
            btnBoleto = new Button();
            btnPix = new Button();
            btnCartao = new Button();
            btnDinheiro = new Button();
            lblFormaPagamento = new Label();
            panel7 = new Panel();
            lblTotal = new Label();
            panel6 = new Panel();
            lblRetornoSubtotal = new Label();
            lblDesconto = new Label();
            lblSubTotal = new Label();
            lblTotais = new Label();
            panel5 = new Panel();
            btnFinalizarVenda = new Button();
            btnAplicarDesconto = new Button();
            btnConsultarPreco = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
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
            lblRetornoValor.Size = new Size(0, 15);
            lblRetornoValor.TabIndex = 7;
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
            lblRetornoProduto.Size = new Size(0, 15);
            lblRetornoProduto.TabIndex = 5;
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
            btnBuscarProduto.Click += btnBuscarProduto_Click;
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
            panel2.Controls.Add(dgvItensVenda);
            panel2.Location = new Point(12, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 332);
            panel2.TabIndex = 1;
            // 
            // lblItensVenda
            // 
            lblItensVenda.AutoSize = true;
            lblItensVenda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItensVenda.Location = new Point(21, 8);
            lblItensVenda.Name = "lblItensVenda";
            lblItensVenda.Size = new Size(148, 25);
            lblItensVenda.TabIndex = 1;
            lblItensVenda.Text = "Itens da Venda:";
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensVenda.Location = new Point(21, 36);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensVenda.Size = new Size(493, 282);
            dgvItensVenda.TabIndex = 0;
            dgvItensVenda.CellContentClick += dgvItensVenda_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(btnNovaVenda);
            panel3.Controls.Add(btnLimparVenda);
            panel3.Controls.Add(btnRemoverItem);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(12, 592);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 102);
            panel3.TabIndex = 1;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.BackColor = Color.FromArgb(128, 128, 255);
            btnNovaVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovaVenda.Location = new Point(396, 22);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.Size = new Size(118, 50);
            btnNovaVenda.TabIndex = 2;
            btnNovaVenda.Text = "NOVA VENDA";
            btnNovaVenda.UseVisualStyleBackColor = false;
            // 
            // btnLimparVenda
            // 
            btnLimparVenda.BackColor = Color.FromArgb(255, 192, 128);
            btnLimparVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparVenda.Location = new Point(211, 22);
            btnLimparVenda.Name = "btnLimparVenda";
            btnLimparVenda.Size = new Size(118, 50);
            btnLimparVenda.TabIndex = 1;
            btnLimparVenda.Text = "LIMPAR VENDA";
            btnLimparVenda.UseVisualStyleBackColor = false;
            // 
            // btnRemoverItem
            // 
            btnRemoverItem.BackColor = Color.FromArgb(255, 128, 128);
            btnRemoverItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemoverItem.ForeColor = Color.Black;
            btnRemoverItem.Location = new Point(28, 22);
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
            panel8.Controls.Add(btnPix);
            panel8.Controls.Add(btnCartao);
            panel8.Controls.Add(btnDinheiro);
            panel8.Controls.Add(lblFormaPagamento);
            panel8.Location = new Point(11, 189);
            panel8.Name = "panel8";
            panel8.Size = new Size(559, 154);
            panel8.TabIndex = 6;
            // 
            // btnBoleto
            // 
            btnBoleto.Location = new Point(389, 43);
            btnBoleto.Name = "btnBoleto";
            btnBoleto.Size = new Size(97, 66);
            btnBoleto.TabIndex = 8;
            btnBoleto.Text = "Boleto";
            btnBoleto.UseVisualStyleBackColor = true;
            // 
            // btnPix
            // 
            btnPix.Location = new Point(286, 43);
            btnPix.Name = "btnPix";
            btnPix.Size = new Size(97, 66);
            btnPix.TabIndex = 7;
            btnPix.Text = "PIX";
            btnPix.UseVisualStyleBackColor = true;
            // 
            // btnCartao
            // 
            btnCartao.Location = new Point(183, 43);
            btnCartao.Name = "btnCartao";
            btnCartao.Size = new Size(97, 66);
            btnCartao.TabIndex = 6;
            btnCartao.Text = "Cartão";
            btnCartao.UseVisualStyleBackColor = true;
            // 
            // btnDinheiro
            // 
            btnDinheiro.Location = new Point(80, 43);
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
            lblFormaPagamento.Location = new Point(13, 9);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(164, 17);
            lblFormaPagamento.TabIndex = 4;
            lblFormaPagamento.Text = "FORMA DE PAGAMENTO:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lblTotal);
            panel7.Location = new Point(11, 125);
            panel7.Name = "panel7";
            panel7.Size = new Size(559, 58);
            panel7.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(13, 16);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(73, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "TOTAL:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblRetornoSubtotal);
            panel6.Controls.Add(lblDesconto);
            panel6.Controls.Add(lblSubTotal);
            panel6.Location = new Point(11, 44);
            panel6.Name = "panel6";
            panel6.Size = new Size(559, 75);
            panel6.TabIndex = 4;
            // 
            // lblRetornoSubtotal
            // 
            lblRetornoSubtotal.AutoSize = true;
            lblRetornoSubtotal.Location = new Point(448, 20);
            lblRetornoSubtotal.Name = "lblRetornoSubtotal";
            lblRetornoSubtotal.Size = new Size(38, 15);
            lblRetornoSubtotal.TabIndex = 5;
            lblRetornoSubtotal.Text = "label1";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesconto.ForeColor = Color.DarkGreen;
            lblDesconto.Location = new Point(14, 41);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(78, 17);
            lblDesconto.TabIndex = 4;
            lblDesconto.Text = "DESCONTO";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(14, 18);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(72, 17);
            lblSubTotal.TabIndex = 3;
            lblSubTotal.Text = "SUBTOTAL";
            // 
            // lblTotais
            // 
            lblTotais.AutoSize = true;
            lblTotais.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotais.Location = new Point(11, 12);
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
            btnFinalizarVenda.BackColor = Color.PaleGreen;
            btnFinalizarVenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFinalizarVenda.ForeColor = Color.Black;
            btnFinalizarVenda.Location = new Point(406, 22);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(118, 50);
            btnFinalizarVenda.TabIndex = 3;
            btnFinalizarVenda.Text = "FINALIZAR VENDA";
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            // 
            // btnAplicarDesconto
            // 
            btnAplicarDesconto.BackColor = Color.FromArgb(128, 255, 255);
            btnAplicarDesconto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicarDesconto.ForeColor = Color.Black;
            btnAplicarDesconto.Location = new Point(232, 22);
            btnAplicarDesconto.Name = "btnAplicarDesconto";
            btnAplicarDesconto.Size = new Size(118, 50);
            btnAplicarDesconto.TabIndex = 2;
            btnAplicarDesconto.Text = "APLICAR DESCONTO";
            btnAplicarDesconto.UseVisualStyleBackColor = false;
            // 
            // btnConsultarPreco
            // 
            btnConsultarPreco.BackColor = Color.FromArgb(255, 255, 128);
            btnConsultarPreco.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConsultarPreco.ForeColor = Color.Black;
            btnConsultarPreco.Location = new Point(52, 22);
            btnConsultarPreco.Name = "btnConsultarPreco";
            btnConsultarPreco.Size = new Size(118, 50);
            btnConsultarPreco.TabIndex = 1;
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
            Text = "GerenciaAPP - Painel de Vendas";
            Load += frmPainelVendas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
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
        private DataGridView dgvItensVenda;
        private Label lblItensVenda;
        private Button btnNovaVenda;
        private Button btnLimparVenda;
        private Button btnRemoverItem;
        private Label lblTotais;
        private Panel panel7;
        private Label lblTotal;
        private Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private Label lblDesconto;
        private Label lblSubTotal;
        private Panel panel8;
        private Label lblFormaPagamento;
        private Button btnBoleto;
        private Button btnPix;
        private Button btnCartao;
        private Button btnDinheiro;
        private Button btnFinalizarVenda;
        private Button btnAplicarDesconto;
        private Button btnConsultarPreco;
        private Label lblRetornoSubtotal;
    }
}