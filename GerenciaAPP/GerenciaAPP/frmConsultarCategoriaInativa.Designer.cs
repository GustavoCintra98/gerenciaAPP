namespace GerenciaAPP
{
    partial class frmConsultarCategoriaInativa
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
            grpConsultarInativos = new GroupBox();
            txtConsultarCategoriaInativa = new TextBox();
            lblConsultarCategoriaInativa = new Label();
            dgvConsultarCategoriaInativa = new DataGridView();
            grpConsultarInativos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCategoriaInativa).BeginInit();
            SuspendLayout();
            // 
            // grpConsultarInativos
            // 
            grpConsultarInativos.Controls.Add(txtConsultarCategoriaInativa);
            grpConsultarInativos.Controls.Add(lblConsultarCategoriaInativa);
            grpConsultarInativos.Location = new Point(12, 12);
            grpConsultarInativos.Name = "grpConsultarInativos";
            grpConsultarInativos.Size = new Size(695, 90);
            grpConsultarInativos.TabIndex = 0;
            grpConsultarInativos.TabStop = false;
            grpConsultarInativos.Text = "Informações de Busca:";
            // 
            // txtConsultarCategoriaInativa
            // 
            txtConsultarCategoriaInativa.Location = new Point(6, 46);
            txtConsultarCategoriaInativa.Name = "txtConsultarCategoriaInativa";
            txtConsultarCategoriaInativa.Size = new Size(402, 23);
            txtConsultarCategoriaInativa.TabIndex = 2;
            txtConsultarCategoriaInativa.TextChanged += txtConsultarCategoriaInativa_TextChanged;
            // 
            // lblConsultarCategoriaInativa
            // 
            lblConsultarCategoriaInativa.AutoSize = true;
            lblConsultarCategoriaInativa.Location = new Point(6, 28);
            lblConsultarCategoriaInativa.Name = "lblConsultarCategoriaInativa";
            lblConsultarCategoriaInativa.Size = new Size(236, 15);
            lblConsultarCategoriaInativa.TabIndex = 1;
            lblConsultarCategoriaInativa.Text = "Informe o nome ou descrição da Categoria:";
            lblConsultarCategoriaInativa.Click += lblConsultarCategoriaInativa_Click;
            // 
            // dgvConsultarCategoriaInativa
            // 
            dgvConsultarCategoriaInativa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultarCategoriaInativa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultarCategoriaInativa.Location = new Point(12, 108);
            dgvConsultarCategoriaInativa.MultiSelect = false;
            dgvConsultarCategoriaInativa.Name = "dgvConsultarCategoriaInativa";
            dgvConsultarCategoriaInativa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultarCategoriaInativa.Size = new Size(695, 330);
            dgvConsultarCategoriaInativa.TabIndex = 1;
            // 
            // frmConsultarCategoriaInativa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(dgvConsultarCategoriaInativa);
            Controls.Add(grpConsultarInativos);
            Name = "frmConsultarCategoriaInativa";
            Text = "GerenciaAPP - Conslultar Categoria Inativa";
            Load += frmConsultarCategoriaInativa_Load;
            grpConsultarInativos.ResumeLayout(false);
            grpConsultarInativos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultarCategoriaInativa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpConsultarInativos;
        private Label lblConsultarCategoriaInativa;
        private DataGridView dgvConsultarCategoriaInativa;
        private TextBox txtConsultarCategoriaInativa;
    }
}