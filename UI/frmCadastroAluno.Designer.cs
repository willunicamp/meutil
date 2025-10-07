namespace UI
{
    partial class frmCadastroAluno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblCPF = new Label();
            lblMatricula = new Label();
            lblDataNascimento = new Label();
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            txtCpf = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            btnSalvar = new Button();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(12, 128);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "CPF";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(12, 191);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "Matrícula";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(218, 128);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(114, 15);
            lblDataNascimento.TabIndex = 3;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(368, 23);
            txtNome.TabIndex = 4;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(12, 209);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 146);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(200, 23);
            txtCpf.TabIndex = 6;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(218, 146);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(162, 23);
            dtpDataNascimento.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(305, 208);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(118, 208);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 10;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(118, 190);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(368, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 67);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "E-mail";
            // 
            // frmCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(btnSalvar);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtMatricula);
            Controls.Add(txtNome);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblMatricula);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Name = "frmCadastroAluno";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCPF;
        private Label lblMatricula;
        private Label lblDataNascimento;
        private TextBox txtNome;
        private TextBox txtMatricula;
        private TextBox txtCpf;
        private DateTimePicker dtpDataNascimento;
        private Button btnSalvar;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}
