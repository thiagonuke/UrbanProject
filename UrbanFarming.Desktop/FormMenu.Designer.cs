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
            SuspendLayout();
            // 
            // buttonProduto
            // 
            buttonProduto.Location = new Point(88, 50);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Size = new Size(175, 47);
            buttonProduto.TabIndex = 0;
            buttonProduto.Text = "Cadastrar Produto";
            buttonProduto.UseVisualStyleBackColor = true;
            buttonProduto.Click += buttonProduto_Click;
            // 
            // buttonPedido
            // 
            buttonPedido.Location = new Point(88, 113);
            buttonPedido.Name = "buttonPedido";
            buttonPedido.Size = new Size(175, 47);
            buttonPedido.TabIndex = 1;
            buttonPedido.Text = "Fazer Pedido";
            buttonPedido.UseVisualStyleBackColor = true;
            buttonPedido.Click += buttonPedido_Click;
            // 
            // buttonListaPedidos
            // 
            buttonListaPedidos.Location = new Point(88, 176);
            buttonListaPedidos.Name = "buttonListaPedidos";
            buttonListaPedidos.Size = new Size(175, 47);
            buttonListaPedidos.TabIndex = 2;
            buttonListaPedidos.Text = "Meus Pedidos";
            buttonListaPedidos.UseVisualStyleBackColor = true;
            buttonListaPedidos.Click += buttonListaPedidos_Click;
            // 
            // buttonFornecedor
            // 
            buttonFornecedor.Location = new Point(88, 239);
            buttonFornecedor.Name = "buttonFornecedor";
            buttonFornecedor.Size = new Size(175, 47);
            buttonFornecedor.TabIndex = 3;
            buttonFornecedor.Text = "Cadastrar Fornecedor";
            buttonFornecedor.UseVisualStyleBackColor = true;
            buttonFornecedor.Click += buttonFornecedor_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(350, 375);
            Controls.Add(buttonFornecedor);
            Controls.Add(buttonListaPedidos);
            Controls.Add(buttonPedido);
            Controls.Add(buttonProduto);
            Name = "FormMenu";
            Text = "Menu Principal";
            ResumeLayout(false);
        }
    }
}
