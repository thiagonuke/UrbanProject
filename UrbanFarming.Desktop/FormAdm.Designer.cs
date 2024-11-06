namespace UrbanFarming.Desktop
{
    partial class FormAdm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox chkAdministrador;
        private System.Windows.Forms.Button btnCadastrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            chkAdministrador = new CheckBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 58);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(117, 115);
            txtSenha.Margin = new Padding(4, 3, 4, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(233, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(117, 173);
            txtNome.Margin = new Padding(4, 3, 4, 3);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(233, 23);
            txtNome.TabIndex = 2;
            // 
            // chkAdministrador
            // 
            chkAdministrador.Location = new Point(117, 231);
            chkAdministrador.Margin = new Padding(4, 3, 4, 3);
            chkAdministrador.Name = "chkAdministrador";
            chkAdministrador.Size = new Size(233, 23);
            chkAdministrador.TabIndex = 3;
            chkAdministrador.Text = "Administrador";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(117, 288);
            btnCadastrar.Margin = new Padding(4, 3, 4, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(233, 35);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(467, 404);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(chkAdministrador);
            Controls.Add(btnCadastrar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAdm";
            Text = "Cadastro de Usuário";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
