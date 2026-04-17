namespace GerenciaAPP
{
    partial class frmCadCategorias
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
            lblNomeCategoria = new Label();
            lblDescricaoCategoria = new Label();
            txtNomeCategoria = new TextBox();
            txtDescricaoCategoria = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize = true;
            lblNomeCategoria.Location = new Point(12, 9);
            lblNomeCategoria.Name = "lblNomeCategoria";
            lblNomeCategoria.Size = new Size(97, 15);
            lblNomeCategoria.TabIndex = 0;
            lblNomeCategoria.Text = "Nome Categoria:";
            // 
            // lblDescricaoCategoria
            // 
            lblDescricaoCategoria.AutoSize = true;
            lblDescricaoCategoria.Location = new Point(12, 53);
            lblDescricaoCategoria.Name = "lblDescricaoCategoria";
            lblDescricaoCategoria.Size = new Size(115, 15);
            lblDescricaoCategoria.TabIndex = 1;
            lblDescricaoCategoria.Text = "Descrição Categoria:";
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(12, 27);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(288, 23);
            txtNomeCategoria.TabIndex = 2;
            txtNomeCategoria.TextChanged += textBox1_TextChanged;
            // 
            // txtDescricaoCategoria
            // 
            txtDescricaoCategoria.Location = new Point(12, 71);
            txtDescricaoCategoria.Name = "txtDescricaoCategoria";
            txtDescricaoCategoria.Size = new Size(288, 23);
            txtDescricaoCategoria.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(225, 100);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(txtDescricaoCategoria);
            Controls.Add(txtNomeCategoria);
            Controls.Add(lblDescricaoCategoria);
            Controls.Add(lblNomeCategoria);
            Name = "frmCadCategorias";
            Text = "GerenciaAPP - Cadastro de Categorias";
            Load += frmCadCategorias_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCategoria;
        private Label lblDescricaoCategoria;
        private TextBox txtNomeCategoria;
        private TextBox txtDescricaoCategoria;
        private Button btnCadastrar;
    }
}