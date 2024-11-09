namespace UrbanFarmingDesktop.UI
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 34F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(449, 83);
            label1.Name = "label1";
            label1.Size = new Size(453, 76);
            label1.TabIndex = 0;
            label1.Text = "Urban Farming";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(535, 353);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(236, 27);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(535, 241);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(236, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.ForeColor = Color.Green;
            lblUsuario.Location = new Point(535, 217);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.ForeColor = Color.Green;
            lblSenha.Location = new Point(535, 329);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(613, 429);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 105);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 383);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 23, 35);
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code

        private Label label1;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblSenha;
        private Button btnLogin;
        private PictureBox pictureBox2;

        #endregion
    }
}