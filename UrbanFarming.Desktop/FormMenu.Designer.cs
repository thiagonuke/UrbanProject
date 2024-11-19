namespace UrbanFarming.Desktop
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonProduto;
        private System.Windows.Forms.Button buttonPedido;
        private System.Windows.Forms.Button buttonFornecedor;
        private System.Windows.Forms.Button buttonListaPedidos;

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
            buttonProduto = new Button();
            buttonPedido = new Button();
            buttonFornecedor = new Button();
            buttonListaPedidos = new Button();
            btnDeletarProd = new Button();
            SuspendLayout();
            // 
            // buttonProduto
            // 
            buttonProduto.Location = new Point(101, 67);
            buttonProduto.Margin = new Padding(3, 4, 3, 4);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Size = new Size(200, 63);
            buttonProduto.TabIndex = 0;
            buttonProduto.Text = "Cadastrar Produto";
            buttonProduto.UseVisualStyleBackColor = true;
            buttonProduto.Visible = false;
            buttonProduto.Click += buttonProduto_Click;
            // 
            // buttonPedido
            // 
            buttonPedido.Location = new Point(101, 151);
            buttonPedido.Margin = new Padding(3, 4, 3, 4);
            buttonPedido.Name = "buttonPedido";
            buttonPedido.Size = new Size(200, 63);
            buttonPedido.TabIndex = 1;
            buttonPedido.Text = "Fazer Pedido";
            buttonPedido.UseVisualStyleBackColor = true;
            buttonPedido.Click += buttonPedido_Click;
            // 
            // buttonFornecedor
            // 
            buttonFornecedor.Location = new Point(101, 319);
            buttonFornecedor.Margin = new Padding(3, 4, 3, 4);
            buttonFornecedor.Name = "buttonFornecedor";
            buttonFornecedor.Size = new Size(200, 63);
            buttonFornecedor.TabIndex = 3;
            buttonFornecedor.Text = "Cadastrar Fornecedor";
            buttonFornecedor.UseVisualStyleBackColor = true;
            buttonFornecedor.Click += buttonFornecedor_Click;
            // 
            // buttonListaPedidos
            // 
            buttonListaPedidos.Location = new Point(101, 235);
            buttonListaPedidos.Margin = new Padding(3, 4, 3, 4);
            buttonListaPedidos.Name = "buttonListaPedidos";
            buttonListaPedidos.Size = new Size(200, 63);
            buttonListaPedidos.TabIndex = 2;
            buttonListaPedidos.Text = "Meus Pedidos";
            buttonListaPedidos.UseVisualStyleBackColor = true;
            buttonListaPedidos.Click += buttonListaPedidos_Click;
            // 
            // btnDeletarProd
            // 
            btnDeletarProd.Location = new Point(101, 402);
            btnDeletarProd.Margin = new Padding(3, 4, 3, 4);
            btnDeletarProd.Name = "btnDeletarProd";
            btnDeletarProd.Size = new Size(200, 63);
            btnDeletarProd.TabIndex = 4;
            btnDeletarProd.Text = "Deletar Produtos";
            btnDeletarProd.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(400, 500);
            Controls.Add(btnDeletarProd);
            Controls.Add(buttonFornecedor);
            Controls.Add(buttonListaPedidos);
            Controls.Add(buttonPedido);
            Controls.Add(buttonProduto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        private Button btnDeletarProd;
    }
}
