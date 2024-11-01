﻿namespace UrbanFarming.Desktop
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
            buttonProduto = new Button();
            buttonPedido = new Button();
            buttonFornecedor = new Button();
            SuspendLayout();
            // 
            // buttonProduto
            // 
            buttonProduto.Location = new Point(88, 94);
            buttonProduto.Name = "buttonProduto";
            buttonProduto.Size = new Size(175, 47);
            buttonProduto.TabIndex = 0;
            buttonProduto.Text = "Cadastrar Produto";
            buttonProduto.UseVisualStyleBackColor = true;
            buttonProduto.Click += buttonProduto_Click;
            // 
            // buttonPedido
            // 
            buttonPedido.Location = new Point(88, 188);
            buttonPedido.Name = "buttonPedido";
            buttonPedido.Size = new Size(175, 47);
            buttonPedido.TabIndex = 1;
            buttonPedido.Text = "Gerenciar Pedidos";
            buttonPedido.UseVisualStyleBackColor = true;
            buttonPedido.Click += buttonPedido_Click;
            // 
            // buttonFornecedor
            // 
            buttonFornecedor.Location = new Point(88, 281);
            buttonFornecedor.Name = "buttonFornecedor";
            buttonFornecedor.Size = new Size(175, 47);
            buttonFornecedor.TabIndex = 2;
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
            Controls.Add(buttonPedido);
            Controls.Add(buttonProduto);
            Name = "FormMenu";
            Text = "Menu Principal";
            ResumeLayout(false);
        }
    }
}
