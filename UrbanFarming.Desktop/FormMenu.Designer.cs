namespace UrbanFarming.Desktop
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonProduto;
        private System.Windows.Forms.Button buttonPedido;
        private System.Windows.Forms.Button buttonFornecedor;

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
            this.components = new System.ComponentModel.Container();
            this.buttonProduto = new System.Windows.Forms.Button();
            this.buttonPedido = new System.Windows.Forms.Button();
            this.buttonFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // buttonProduto
            // 
            this.buttonProduto.Location = new System.Drawing.Point(100, 100);
            this.buttonProduto.Name = "buttonProduto";
            this.buttonProduto.Size = new System.Drawing.Size(200, 50);
            this.buttonProduto.TabIndex = 0;
            this.buttonProduto.Text = "Cadastrar Produto";
            this.buttonProduto.UseVisualStyleBackColor = true;
            this.buttonProduto.Click += new System.EventHandler(this.buttonProduto_Click);

            // 
            // buttonPedido
            // 
            this.buttonPedido.Location = new System.Drawing.Point(100, 200);
            this.buttonPedido.Name = "buttonPedido";
            this.buttonPedido.Size = new System.Drawing.Size(200, 50);
            this.buttonPedido.TabIndex = 1;
            this.buttonPedido.Text = "Gerenciar Pedidos";
            this.buttonPedido.UseVisualStyleBackColor = true;
            this.buttonPedido.Click += new System.EventHandler(this.buttonPedido_Click);

            // 
            // buttonFornecedor
            // 
            this.buttonFornecedor.Location = new System.Drawing.Point(100, 300);
            this.buttonFornecedor.Name = "buttonFornecedor";
            this.buttonFornecedor.Size = new System.Drawing.Size(200, 50);
            this.buttonFornecedor.TabIndex = 2;
            this.buttonFornecedor.Text = "Cadastrar Fornecedor";
            this.buttonFornecedor.UseVisualStyleBackColor = true;
            this.buttonFornecedor.Click += new System.EventHandler(this.buttonFornecedor_Click);

            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.buttonFornecedor);
            this.Controls.Add(this.buttonPedido);
            this.Controls.Add(this.buttonProduto);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
        }
    }
}
