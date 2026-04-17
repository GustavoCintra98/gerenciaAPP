namespace GerenciaAPP
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem1 = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            fiscalToolStripMenuItem = new ToolStripMenuItem();
            pDVToolStripMenuItem = new ToolStripMenuItem();
            emissãoNFeToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            printDialog1 = new PrintDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, consultasToolStripMenuItem, fiscalToolStripMenuItem, relatóriosToolStripMenuItem, configuraçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(919, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, clientesToolStripMenuItem, fornecedoresToolStripMenuItem, produtosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(145, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(145, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(145, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem1, clientesToolStripMenuItem1, fornecedoresToolStripMenuItem1, produtosToolStripMenuItem1 });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // categoriasToolStripMenuItem1
            // 
            categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            categoriasToolStripMenuItem1.ShortcutKeys = Keys.F2;
            categoriasToolStripMenuItem1.Size = new Size(180, 22);
            categoriasToolStripMenuItem1.Text = "Categorias";
            categoriasToolStripMenuItem1.Click += categoriasToolStripMenuItem1_Click_1;
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.ShortcutKeys = Keys.F3;
            clientesToolStripMenuItem1.Size = new Size(180, 22);
            clientesToolStripMenuItem1.Text = "Clientes";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // fornecedoresToolStripMenuItem1
            // 
            fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            fornecedoresToolStripMenuItem1.ShortcutKeys = Keys.F4;
            fornecedoresToolStripMenuItem1.Size = new Size(180, 22);
            fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            fornecedoresToolStripMenuItem1.Click += fornecedoresToolStripMenuItem1_Click;
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.ShortcutKeys = Keys.F5;
            produtosToolStripMenuItem1.Size = new Size(180, 22);
            produtosToolStripMenuItem1.Text = "Produtos";
            produtosToolStripMenuItem1.Click += produtosToolStripMenuItem1_Click;
            // 
            // fiscalToolStripMenuItem
            // 
            fiscalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pDVToolStripMenuItem, emissãoNFeToolStripMenuItem });
            fiscalToolStripMenuItem.Name = "fiscalToolStripMenuItem";
            fiscalToolStripMenuItem.Size = new Size(48, 20);
            fiscalToolStripMenuItem.Text = "Fiscal";
            // 
            // pDVToolStripMenuItem
            // 
            pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            pDVToolStripMenuItem.Size = new Size(146, 22);
            pDVToolStripMenuItem.Text = "PDV";
            // 
            // emissãoNFeToolStripMenuItem
            // 
            emissãoNFeToolStripMenuItem.Name = "emissãoNFeToolStripMenuItem";
            emissãoNFeToolStripMenuItem.Size = new Size(146, 22);
            emissãoNFeToolStripMenuItem.Text = "Emissão NF-e";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 504);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(919, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 526);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Name = "frmPrincipal";
            Text = "GerenciaAPP - Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem fiscalToolStripMenuItem;
        private ToolStripMenuItem pDVToolStripMenuItem;
        private ToolStripMenuItem emissãoNFeToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem categoriasToolStripMenuItem1;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private PrintDialog printDialog1;
    }
}