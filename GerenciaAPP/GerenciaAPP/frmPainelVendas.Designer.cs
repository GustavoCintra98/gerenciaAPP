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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            txtCodigoBarras = new TextBox();
            lblCodigoBarras = new Label();
            btnBuscarProduto = new Button();
            pictureBox1 = new PictureBox();
            lblProduto = new Label();
            lblRetornoProduto = new Label();
            lblValor = new Label();
            lblRetornoValor = new Label();
            lblEstoque = new Label();
            lblRetornoEstoque = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Size = new Size(450, 180);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 264);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(12, 468);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 117);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(468, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(438, 450);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Location = new Point(468, 468);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 117);
            panel5.TabIndex = 3;
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(14, 32);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(344, 23);
            txtCodigoBarras.TabIndex = 0;
            // 
            // lblCodigoBarras
            // 
            lblCodigoBarras.AutoSize = true;
            lblCodigoBarras.Location = new Point(14, 14);
            lblCodigoBarras.Name = "lblCodigoBarras";
            lblCodigoBarras.Size = new Size(118, 15);
            lblCodigoBarras.TabIndex = 1;
            lblCodigoBarras.Text = "CÓDIGO DE BARRAS:";
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.Location = new Point(364, 32);
            btnBuscarProduto.Name = "btnBuscarProduto";
            btnBuscarProduto.Size = new Size(83, 23);
            btnBuscarProduto.TabIndex = 2;
            btnBuscarProduto.Text = "Buscar";
            btnBuscarProduto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 106);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(113, 61);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(64, 15);
            lblProduto.TabIndex = 4;
            lblProduto.Text = "PRODUTO:";
            // 
            // lblRetornoProduto
            // 
            lblRetornoProduto.AutoSize = true;
            lblRetornoProduto.Location = new Point(113, 91);
            lblRetornoProduto.Name = "lblRetornoProduto";
            lblRetornoProduto.Size = new Size(38, 15);
            lblRetornoProduto.TabIndex = 5;
            lblRetornoProduto.Text = "label3";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(113, 120);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(46, 15);
            lblValor.TabIndex = 6;
            lblValor.Text = "VALOR:";
            // 
            // lblRetornoValor
            // 
            lblRetornoValor.AutoSize = true;
            lblRetornoValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetornoValor.ForeColor = Color.LimeGreen;
            lblRetornoValor.Location = new Point(113, 152);
            lblRetornoValor.Name = "lblRetornoValor";
            lblRetornoValor.Size = new Size(40, 15);
            lblRetornoValor.TabIndex = 7;
            lblRetornoValor.Text = "label5";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(266, 120);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(60, 15);
            lblEstoque.TabIndex = 8;
            lblEstoque.Text = "ESTOQUE:";
            // 
            // lblRetornoEstoque
            // 
            lblRetornoEstoque.AutoSize = true;
            lblRetornoEstoque.Location = new Point(266, 152);
            lblRetornoEstoque.Name = "lblRetornoEstoque";
            lblRetornoEstoque.Size = new Size(38, 15);
            lblRetornoEstoque.TabIndex = 9;
            lblRetornoEstoque.Text = "label7";
            // 
            // frmPainelVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 597);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblCodigoBarras;
        private TextBox txtCodigoBarras;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblRetornoEstoque;
        private Label lblEstoque;
        private Label lblRetornoValor;
        private Label lblValor;
        private Label lblRetornoProduto;
        private Label lblProduto;
        private PictureBox pictureBox1;
        private Button btnBuscarProduto;
    }
}