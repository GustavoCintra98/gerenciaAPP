namespace GerenciaAPP
{
    partial class frmCadClientes
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
            lblNomeCliente = new Label();
            grbInformacoesPessoais = new GroupBox();
            cmbGenero = new ComboBox();
            lblGenero = new Label();
            mskDataNascimento = new MaskedTextBox();
            lblDataNascimento = new Label();
            mskCPFCliente = new MaskedTextBox();
            lblCPFCliente = new Label();
            txtNomeCliente = new TextBox();
            grbInformacoesEndereco = new GroupBox();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtNumeroEndereco = new TextBox();
            lblNumeroEndereco = new Label();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            mskCEP = new MaskedTextBox();
            lblCEP = new Label();
            grbInformacoesContato = new GroupBox();
            txtEmail = new TextBox();
            chkWhatsapp = new CheckBox();
            mskCelular = new MaskedTextBox();
            mskTelefone = new MaskedTextBox();
            lblEmail = new Label();
            lblWhatsapp = new Label();
            lblCelular = new Label();
            lblTelefone = new Label();
            grbInformacoesAdicionais = new GroupBox();
            txtObservacoes = new TextBox();
            lblObservacoes = new Label();
            btnCadastrar = new Button();
            grbInformacoesPessoais.SuspendLayout();
            grbInformacoesEndereco.SuspendLayout();
            grbInformacoesContato.SuspendLayout();
            grbInformacoesAdicionais.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(6, 19);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(99, 15);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "Nome Completo:";
            // 
            // grbInformacoesPessoais
            // 
            grbInformacoesPessoais.Controls.Add(cmbGenero);
            grbInformacoesPessoais.Controls.Add(lblGenero);
            grbInformacoesPessoais.Controls.Add(mskDataNascimento);
            grbInformacoesPessoais.Controls.Add(lblDataNascimento);
            grbInformacoesPessoais.Controls.Add(mskCPFCliente);
            grbInformacoesPessoais.Controls.Add(lblCPFCliente);
            grbInformacoesPessoais.Controls.Add(txtNomeCliente);
            grbInformacoesPessoais.Controls.Add(lblNomeCliente);
            grbInformacoesPessoais.Location = new Point(12, 12);
            grbInformacoesPessoais.Name = "grbInformacoesPessoais";
            grbInformacoesPessoais.Size = new Size(768, 119);
            grbInformacoesPessoais.TabIndex = 1;
            grbInformacoesPessoais.TabStop = false;
            grbInformacoesPessoais.Text = "Informações Pessoais:";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "F", "M", "O" });
            cmbGenero.Location = new Point(216, 81);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(109, 23);
            cmbGenero.TabIndex = 7;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(216, 63);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 6;
            lblGenero.Text = "Gênero:";
            // 
            // mskDataNascimento
            // 
            mskDataNascimento.Location = new Point(93, 81);
            mskDataNascimento.Mask = "00/00/0000";
            mskDataNascimento.Name = "mskDataNascimento";
            mskDataNascimento.Size = new Size(117, 23);
            mskDataNascimento.TabIndex = 5;
            mskDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(93, 63);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(117, 15);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // mskCPFCliente
            // 
            mskCPFCliente.Location = new Point(6, 81);
            mskCPFCliente.Mask = "000.000.000-00";
            mskCPFCliente.Name = "mskCPFCliente";
            mskCPFCliente.Size = new Size(81, 23);
            mskCPFCliente.TabIndex = 3;
            // 
            // lblCPFCliente
            // 
            lblCPFCliente.AutoSize = true;
            lblCPFCliente.Location = new Point(6, 63);
            lblCPFCliente.Name = "lblCPFCliente";
            lblCPFCliente.Size = new Size(31, 15);
            lblCPFCliente.TabIndex = 2;
            lblCPFCliente.Text = "CPF:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(6, 37);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(319, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // grbInformacoesEndereco
            // 
            grbInformacoesEndereco.Controls.Add(txtComplemento);
            grbInformacoesEndereco.Controls.Add(lblComplemento);
            grbInformacoesEndereco.Controls.Add(txtEstado);
            grbInformacoesEndereco.Controls.Add(lblEstado);
            grbInformacoesEndereco.Controls.Add(txtCidade);
            grbInformacoesEndereco.Controls.Add(lblCidade);
            grbInformacoesEndereco.Controls.Add(txtBairro);
            grbInformacoesEndereco.Controls.Add(lblBairro);
            grbInformacoesEndereco.Controls.Add(txtNumeroEndereco);
            grbInformacoesEndereco.Controls.Add(lblNumeroEndereco);
            grbInformacoesEndereco.Controls.Add(txtEndereco);
            grbInformacoesEndereco.Controls.Add(lblEndereco);
            grbInformacoesEndereco.Controls.Add(mskCEP);
            grbInformacoesEndereco.Controls.Add(lblCEP);
            grbInformacoesEndereco.Location = new Point(12, 137);
            grbInformacoesEndereco.Name = "grbInformacoesEndereco";
            grbInformacoesEndereco.Size = new Size(768, 110);
            grbInformacoesEndereco.TabIndex = 2;
            grbInformacoesEndereco.TabStop = false;
            grbInformacoesEndereco.Text = "Informações de Endereço:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(93, 81);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(669, 23);
            txtComplemento.TabIndex = 13;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(93, 63);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(87, 15);
            lblComplemento.TabIndex = 12;
            lblComplemento.Text = "Complemento:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(6, 81);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(81, 23);
            txtEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(6, 63);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(24, 15);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "UF:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(595, 37);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(167, 23);
            txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(592, 19);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 8;
            lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(439, 37);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(150, 23);
            txtBairro.TabIndex = 7;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(435, 19);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 6;
            lblBairro.Text = "Bairro:";
            // 
            // txtNumeroEndereco
            // 
            txtNumeroEndereco.Location = new Point(364, 37);
            txtNumeroEndereco.Name = "txtNumeroEndereco";
            txtNumeroEndereco.Size = new Size(69, 23);
            txtNumeroEndereco.TabIndex = 5;
            // 
            // lblNumeroEndereco
            // 
            lblNumeroEndereco.AutoSize = true;
            lblNumeroEndereco.Location = new Point(363, 19);
            lblNumeroEndereco.Name = "lblNumeroEndereco";
            lblNumeroEndereco.Size = new Size(24, 15);
            lblNumeroEndereco.TabIndex = 4;
            lblNumeroEndereco.Text = "Nº:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(93, 37);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(265, 23);
            txtEndereco.TabIndex = 3;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(93, 19);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(6, 37);
            mskCEP.Mask = "00000-999";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(81, 23);
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
            // grbInformacoesContato
            // 
            grbInformacoesContato.Controls.Add(txtEmail);
            grbInformacoesContato.Controls.Add(chkWhatsapp);
            grbInformacoesContato.Controls.Add(mskCelular);
            grbInformacoesContato.Controls.Add(mskTelefone);
            grbInformacoesContato.Controls.Add(lblEmail);
            grbInformacoesContato.Controls.Add(lblWhatsapp);
            grbInformacoesContato.Controls.Add(lblCelular);
            grbInformacoesContato.Controls.Add(lblTelefone);
            grbInformacoesContato.Location = new Point(12, 253);
            grbInformacoesContato.Name = "grbInformacoesContato";
            grbInformacoesContato.Size = new Size(768, 75);
            grbInformacoesContato.TabIndex = 3;
            grbInformacoesContato.TabStop = false;
            grbInformacoesContato.Text = "Informações de Contato:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(294, 35);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 23);
            txtEmail.TabIndex = 7;
            // 
            // chkWhatsapp
            // 
            chkWhatsapp.AutoSize = true;
            chkWhatsapp.Location = new Point(218, 39);
            chkWhatsapp.Name = "chkWhatsapp";
            chkWhatsapp.Size = new Size(46, 19);
            chkWhatsapp.TabIndex = 6;
            chkWhatsapp.Text = "Sim";
            chkWhatsapp.UseVisualStyleBackColor = true;
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(112, 37);
            mskCelular.Mask = "(00)00000-0000";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(100, 23);
            mskCelular.TabIndex = 5;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(6, 37);
            mskTelefone.Mask = "(00)0000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(100, 23);
            mskTelefone.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(294, 19);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail:";
            // 
            // lblWhatsapp
            // 
            lblWhatsapp.AutoSize = true;
            lblWhatsapp.Location = new Point(216, 19);
            lblWhatsapp.Name = "lblWhatsapp";
            lblWhatsapp.Size = new Size(72, 15);
            lblWhatsapp.TabIndex = 2;
            lblWhatsapp.Text = "É whatsapp?";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(112, 19);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 1;
            lblCelular.Text = "Celular:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(6, 19);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(55, 15);
            lblTelefone.TabIndex = 0;
            lblTelefone.Text = "Telefone:";
            // 
            // grbInformacoesAdicionais
            // 
            grbInformacoesAdicionais.Controls.Add(txtObservacoes);
            grbInformacoesAdicionais.Controls.Add(lblObservacoes);
            grbInformacoesAdicionais.Location = new Point(12, 334);
            grbInformacoesAdicionais.Name = "grbInformacoesAdicionais";
            grbInformacoesAdicionais.Size = new Size(768, 182);
            grbInformacoesAdicionais.TabIndex = 4;
            grbInformacoesAdicionais.TabStop = false;
            grbInformacoesAdicionais.Text = "Informações Adicionais:";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(6, 37);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(756, 132);
            txtObservacoes.TabIndex = 2;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(6, 19);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(77, 15);
            lblObservacoes.TabIndex = 0;
            lblObservacoes.Text = "Observações:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(705, 523);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCadClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 551);
            Controls.Add(btnCadastrar);
            Controls.Add(grbInformacoesAdicionais);
            Controls.Add(grbInformacoesContato);
            Controls.Add(grbInformacoesEndereco);
            Controls.Add(grbInformacoesPessoais);
            Name = "frmCadClientes";
            Text = "GerenciaAPP - Cadastrar Cliente";
            grbInformacoesPessoais.ResumeLayout(false);
            grbInformacoesPessoais.PerformLayout();
            grbInformacoesEndereco.ResumeLayout(false);
            grbInformacoesEndereco.PerformLayout();
            grbInformacoesContato.ResumeLayout(false);
            grbInformacoesContato.PerformLayout();
            grbInformacoesAdicionais.ResumeLayout(false);
            grbInformacoesAdicionais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNomeCliente;
        private GroupBox grbInformacoesPessoais;
        private TextBox txtNomeCliente;
        private MaskedTextBox mskCPFCliente;
        private Label lblCPFCliente;
        private MaskedTextBox mskDataNascimento;
        private Label lblDataNascimento;
        private Label lblGenero;
        private ComboBox cmbGenero;
        private GroupBox grbInformacoesEndereco;
        private Label lblCEP;
        private MaskedTextBox mskCEP;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label lblNumeroEndereco;
        private TextBox txtNumeroEndereco;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblCidade;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private Label lblEstado;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private GroupBox grbInformacoesContato;
        private Label lblEmail;
        private Label lblWhatsapp;
        private Label lblCelular;
        private Label lblTelefone;
        private MaskedTextBox mskCelular;
        private MaskedTextBox mskTelefone;
        private CheckBox chkWhatsapp;
        private TextBox txtEmail;
        private GroupBox grbInformacoesAdicionais;
        private Label lblObservacoes;
        private TextBox txtObservacoes;
        private Button btnCadastrar;
    }
}