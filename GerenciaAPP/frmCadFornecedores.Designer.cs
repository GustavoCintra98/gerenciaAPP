namespace GerenciaAPP
{
    partial class frmCadFornecedores
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
            grbInformacoesFiscais = new GroupBox();
            txtInscricaoEstadual = new TextBox();
            lblInscricaoEstadual = new Label();
            txtInscricaoMunicipal = new TextBox();
            lblInscricaoMunicipal = new Label();
            txtCNAESecundario = new TextBox();
            lblCNAESecundario = new Label();
            txtCNAEPrincipal = new TextBox();
            lblCNAEPrincipal = new Label();
            txtPorte = new TextBox();
            lblPorte = new Label();
            txtNomeFantasia = new TextBox();
            lblNomeFantasia = new Label();
            txtRazaoSocial = new TextBox();
            lblRazaoSocial = new Label();
            mskCNPJ = new MaskedTextBox();
            lblCNPJ = new Label();
            grbInformacoesContato = new GroupBox();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            txtResponsavel = new TextBox();
            lblResponsavel = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            mskCelular = new MaskedTextBox();
            lblCelular = new Label();
            mskTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtUF = new TextBox();
            lblEstado = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            mskCEP = new MaskedTextBox();
            lblCEP = new Label();
            btnCadastrar = new Button();
            grbInformacoesFiscais.SuspendLayout();
            grbInformacoesContato.SuspendLayout();
            SuspendLayout();
            // 
            // grbInformacoesFiscais
            // 
            grbInformacoesFiscais.Controls.Add(txtInscricaoEstadual);
            grbInformacoesFiscais.Controls.Add(lblInscricaoEstadual);
            grbInformacoesFiscais.Controls.Add(txtInscricaoMunicipal);
            grbInformacoesFiscais.Controls.Add(lblInscricaoMunicipal);
            grbInformacoesFiscais.Controls.Add(txtCNAESecundario);
            grbInformacoesFiscais.Controls.Add(lblCNAESecundario);
            grbInformacoesFiscais.Controls.Add(txtCNAEPrincipal);
            grbInformacoesFiscais.Controls.Add(lblCNAEPrincipal);
            grbInformacoesFiscais.Controls.Add(txtPorte);
            grbInformacoesFiscais.Controls.Add(lblPorte);
            grbInformacoesFiscais.Controls.Add(txtNomeFantasia);
            grbInformacoesFiscais.Controls.Add(lblNomeFantasia);
            grbInformacoesFiscais.Controls.Add(txtRazaoSocial);
            grbInformacoesFiscais.Controls.Add(lblRazaoSocial);
            grbInformacoesFiscais.Controls.Add(mskCNPJ);
            grbInformacoesFiscais.Controls.Add(lblCNPJ);
            grbInformacoesFiscais.Location = new Point(12, 12);
            grbInformacoesFiscais.Name = "grbInformacoesFiscais";
            grbInformacoesFiscais.Size = new Size(818, 183);
            grbInformacoesFiscais.TabIndex = 0;
            grbInformacoesFiscais.TabStop = false;
            grbInformacoesFiscais.Text = "Informações Fiscais:";
            // 
            // txtInscricaoEstadual
            // 
            txtInscricaoEstadual.Location = new Point(525, 81);
            txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            txtInscricaoEstadual.Size = new Size(131, 23);
            txtInscricaoEstadual.TabIndex = 15;
            // 
            // lblInscricaoEstadual
            // 
            lblInscricaoEstadual.AutoSize = true;
            lblInscricaoEstadual.Location = new Point(525, 63);
            lblInscricaoEstadual.Name = "lblInscricaoEstadual";
            lblInscricaoEstadual.Size = new Size(104, 15);
            lblInscricaoEstadual.TabIndex = 14;
            lblInscricaoEstadual.Text = "Inscrição Estadual:";
            // 
            // txtInscricaoMunicipal
            // 
            txtInscricaoMunicipal.Location = new Point(388, 81);
            txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            txtInscricaoMunicipal.Size = new Size(131, 23);
            txtInscricaoMunicipal.TabIndex = 13;
            // 
            // lblInscricaoMunicipal
            // 
            lblInscricaoMunicipal.AutoSize = true;
            lblInscricaoMunicipal.Location = new Point(384, 63);
            lblInscricaoMunicipal.Name = "lblInscricaoMunicipal";
            lblInscricaoMunicipal.Size = new Size(113, 15);
            lblInscricaoMunicipal.TabIndex = 12;
            lblInscricaoMunicipal.Text = "Inscrição Municipal:";
            // 
            // txtCNAESecundario
            // 
            txtCNAESecundario.Location = new Point(223, 81);
            txtCNAESecundario.Multiline = true;
            txtCNAESecundario.Name = "txtCNAESecundario";
            txtCNAESecundario.Size = new Size(159, 93);
            txtCNAESecundario.TabIndex = 11;
            // 
            // lblCNAESecundario
            // 
            lblCNAESecundario.AutoSize = true;
            lblCNAESecundario.Location = new Point(219, 63);
            lblCNAESecundario.Name = "lblCNAESecundario";
            lblCNAESecundario.Size = new Size(111, 15);
            lblCNAESecundario.TabIndex = 10;
            lblCNAESecundario.Text = "CNAE - Secundário:";
            // 
            // txtCNAEPrincipal
            // 
            txtCNAEPrincipal.Location = new Point(106, 81);
            txtCNAEPrincipal.Name = "txtCNAEPrincipal";
            txtCNAEPrincipal.Size = new Size(111, 23);
            txtCNAEPrincipal.TabIndex = 9;
            // 
            // lblCNAEPrincipal
            // 
            lblCNAEPrincipal.AutoSize = true;
            lblCNAEPrincipal.Location = new Point(102, 63);
            lblCNAEPrincipal.Name = "lblCNAEPrincipal";
            lblCNAEPrincipal.Size = new Size(98, 15);
            lblCNAEPrincipal.TabIndex = 8;
            lblCNAEPrincipal.Text = "CNAE - Principal:";
            // 
            // txtPorte
            // 
            txtPorte.Location = new Point(6, 81);
            txtPorte.Name = "txtPorte";
            txtPorte.Size = new Size(90, 23);
            txtPorte.TabIndex = 7;
            // 
            // lblPorte
            // 
            lblPorte.AutoSize = true;
            lblPorte.Location = new Point(6, 63);
            lblPorte.Name = "lblPorte";
            lblPorte.Size = new Size(38, 15);
            lblPorte.TabIndex = 6;
            lblPorte.Text = "Porte:";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Location = new Point(525, 37);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(284, 23);
            txtNomeFantasia.TabIndex = 5;
            // 
            // lblNomeFantasia
            // 
            lblNomeFantasia.AutoSize = true;
            lblNomeFantasia.Location = new Point(525, 19);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(89, 15);
            lblNomeFantasia.TabIndex = 4;
            lblNomeFantasia.Text = "Nome Fantasia:";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(146, 37);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(373, 23);
            txtRazaoSocial.TabIndex = 3;
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(142, 19);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(75, 15);
            lblRazaoSocial.TabIndex = 2;
            lblRazaoSocial.Text = "Razão Social:";
            // 
            // mskCNPJ
            // 
            mskCNPJ.Location = new Point(6, 37);
            mskCNPJ.Mask = "00.000.000/0000-00";
            mskCNPJ.Name = "mskCNPJ";
            mskCNPJ.Size = new Size(134, 23);
            mskCNPJ.TabIndex = 1;
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(6, 19);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(37, 15);
            lblCNPJ.TabIndex = 0;
            lblCNPJ.Text = "CNPJ:";
            // 
            // grbInformacoesContato
            // 
            grbInformacoesContato.Controls.Add(txtObservacoes);
            grbInformacoesContato.Controls.Add(lblObservacoes);
            grbInformacoesContato.Controls.Add(txtResponsavel);
            grbInformacoesContato.Controls.Add(lblResponsavel);
            grbInformacoesContato.Controls.Add(txtEmail);
            grbInformacoesContato.Controls.Add(lblEmail);
            grbInformacoesContato.Controls.Add(mskCelular);
            grbInformacoesContato.Controls.Add(lblCelular);
            grbInformacoesContato.Controls.Add(mskTelefone);
            grbInformacoesContato.Controls.Add(lblTelefone);
            grbInformacoesContato.Controls.Add(txtComplemento);
            grbInformacoesContato.Controls.Add(lblComplemento);
            grbInformacoesContato.Controls.Add(txtUF);
            grbInformacoesContato.Controls.Add(lblEstado);
            grbInformacoesContato.Controls.Add(txtCidade);
            grbInformacoesContato.Controls.Add(lblCidade);
            grbInformacoesContato.Controls.Add(txtBairro);
            grbInformacoesContato.Controls.Add(lblBairro);
            grbInformacoesContato.Controls.Add(txtNumero);
            grbInformacoesContato.Controls.Add(lblNumero);
            grbInformacoesContato.Controls.Add(txtEndereco);
            grbInformacoesContato.Controls.Add(lblEndereco);
            grbInformacoesContato.Controls.Add(mskCEP);
            grbInformacoesContato.Controls.Add(lblCEP);
            grbInformacoesContato.Location = new Point(12, 201);
            grbInformacoesContato.Name = "grbInformacoesContato";
            grbInformacoesContato.Size = new Size(818, 246);
            grbInformacoesContato.TabIndex = 1;
            grbInformacoesContato.TabStop = false;
            grbInformacoesContato.Text = "Informações de Contato:";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(6, 169);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(803, 66);
            txtObservacoes.TabIndex = 23;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(6, 151);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(77, 15);
            lblObservacoes.TabIndex = 22;
            lblObservacoes.Text = "Observações:";
            // 
            // txtResponsavel
            // 
            txtResponsavel.Location = new Point(6, 125);
            txtResponsavel.Name = "txtResponsavel";
            txtResponsavel.Size = new Size(134, 23);
            txtResponsavel.TabIndex = 21;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(6, 107);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(75, 15);
            lblResponsavel.TabIndex = 20;
            lblResponsavel.Text = "Responsável:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(557, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 23);
            txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(556, 63);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "E-mail:";
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(473, 81);
            mskCelular.Mask = "(00)00000-0000";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(78, 23);
            mskCelular.TabIndex = 17;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(472, 63);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 16;
            lblCelular.Text = "Celular:";
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(388, 81);
            mskTelefone.Mask = "(00)0000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(79, 23);
            mskTelefone.TabIndex = 15;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(388, 63);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 14;
            lblTelefone.Text = "Telefone:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(6, 81);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(376, 23);
            txtComplemento.TabIndex = 13;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(6, 63);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(87, 15);
            lblComplemento.TabIndex = 12;
            lblComplemento.Text = "Complemento:";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(748, 37);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(61, 23);
            txtUF.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(748, 19);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(24, 15);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "UF:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(600, 37);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(142, 23);
            txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(600, 19);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(464, 37);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(130, 23);
            txtBairro.TabIndex = 7;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(464, 19);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 6;
            lblBairro.Text = "Bairro:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(388, 37);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(70, 23);
            txtNumero.TabIndex = 5;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(384, 19);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(24, 15);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Nº:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(81, 37);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(301, 23);
            txtEndereco.TabIndex = 3;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(81, 19);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(6, 37);
            mskCEP.Mask = "00000-000";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(69, 23);
            mskCEP.TabIndex = 1;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(6, 19);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(31, 15);
            lblCEP.TabIndex = 0;
            lblCEP.Text = "CEP:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(755, 453);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 482);
            Controls.Add(btnCadastrar);
            Controls.Add(grbInformacoesContato);
            Controls.Add(grbInformacoesFiscais);
            Name = "frmCadFornecedores";
            Text = "GerenciaAPP - Cadastrar Fornecedores";
            grbInformacoesFiscais.ResumeLayout(false);
            grbInformacoesFiscais.PerformLayout();
            grbInformacoesContato.ResumeLayout(false);
            grbInformacoesContato.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformacoesFiscais;
        private MaskedTextBox mskCNPJ;
        private Label lblCNPJ;
        private Label lblRazaoSocial;
        private TextBox txtRazaoSocial;
        private Label lblNomeFantasia;
        private TextBox txtNomeFantasia;
        private Label lblPorte;
        private TextBox txtPorte;
        private TextBox txtCNAEPrincipal;
        private Label lblCNAEPrincipal;
        private TextBox txtCNAESecundario;
        private Label lblCNAESecundario;
        private Label lblInscricaoMunicipal;
        private TextBox txtInscricaoMunicipal;
        private Label lblInscricaoEstadual;
        private TextBox txtInscricaoEstadual;
        private GroupBox grbInformacoesContato;
        private Label lblCEP;
        private MaskedTextBox mskCEP;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private Label lblNumero;
        private Label lblBairro;
        private TextBox txtNumero;
        private TextBox txtBairro;
        private Label lblCidade;
        private TextBox txtCidade;
        private TextBox txtUF;
        private Label lblEstado;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private Label lblTelefone;
        private MaskedTextBox mskTelefone;
        private Label lblCelular;
        private MaskedTextBox mskCelular;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblResponsavel;
        private TextBox txtResponsavel;
        private Label lblObservacoes;
        private TextBox txtObservacoes;
        private Button btnCadastrar;
    }
}