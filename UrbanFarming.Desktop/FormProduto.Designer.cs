namespace UrbanFarming.Desktop
{
    partial class FormProduto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelLinkImagem;
        private System.Windows.Forms.TextBox textBoxLinkImagem;
        private System.Windows.Forms.Button buttonCadastrar;

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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelLinkImagem = new System.Windows.Forms.Label();
            this.textBoxLinkImagem = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();

            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(20, 20);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código:";

            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(100, 20);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodigo.TabIndex = 1;

            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(20, 60);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";

            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(100, 60);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(200, 20);
            this.textBoxNome.TabIndex = 3;

            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(20, 100);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(36, 13);
            this.labelValor.TabIndex = 4;
            this.labelValor.Text = "Valor:";

            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(100, 100);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(200, 20);
            this.textBoxValor.TabIndex = 5;

            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(20, 140);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(60, 13);
            this.labelDescricao.TabIndex = 6;
            this.labelDescricao.Text = "Descrição:";

            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(100, 140);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(200, 60);
            this.textBoxDescricao.TabIndex = 7;

            // 
            // labelLinkImagem
            // 
            this.labelLinkImagem.AutoSize = true;
            this.labelLinkImagem.Location = new System.Drawing.Point(20, 220);
            this.labelLinkImagem.Name = "labelLinkImagem";
            this.labelLinkImagem.Size = new System.Drawing.Size(74, 13);
            this.labelLinkImagem.TabIndex = 8;
            this.labelLinkImagem.Text = "Link da Imagem:";

            // 
            // textBoxLinkImagem
            // 
            this.textBoxLinkImagem.Location = new System.Drawing.Point(100, 220);
            this.textBoxLinkImagem.Name = "textBoxLinkImagem";
            this.textBoxLinkImagem.Size = new System.Drawing.Size(200, 20);
            this.textBoxLinkImagem.TabIndex = 9;

            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(100, 260);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(200, 30);
            this.buttonCadastrar.TabIndex = 10;
            this.buttonCadastrar.Text = "Cadastrar Produto";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);

            // 
            // FormProduto
            // 
            this.ClientSize = new System.Drawing.Size(320, 320);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelLinkImagem);
            this.Controls.Add(this.textBoxLinkImagem);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "FormProduto";
            this.Text = "Cadastrar Produto";
        }
    }
}
