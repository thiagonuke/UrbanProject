namespace UrbanFarmingDesktop.UI
{
    partial class FormPedido
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Button buttonAdicionarAoCarrinho;
        private System.Windows.Forms.DataGridView dataGridViewCarrinho;
        private System.Windows.Forms.Button buttonFinalizarCompra;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;

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
            dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            buttonAdicionarAoCarrinho = new System.Windows.Forms.Button();
            dataGridViewCarrinho = new System.Windows.Forms.DataGridView();
            buttonFinalizarCompra = new System.Windows.Forms.Button();
            labelTotal = new System.Windows.Forms.Label();
            textBoxTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new System.Drawing.Point(12, 12);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.ReadOnly = true;
            dataGridViewProdutos.Size = new System.Drawing.Size(360, 400);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // buttonAdicionarAoCarrinho
            // 
            buttonAdicionarAoCarrinho.Location = new System.Drawing.Point(378, 12);
            buttonAdicionarAoCarrinho.Name = "buttonAdicionarAoCarrinho";
            buttonAdicionarAoCarrinho.Size = new System.Drawing.Size(150, 30);
            buttonAdicionarAoCarrinho.TabIndex = 1;
            buttonAdicionarAoCarrinho.Text = "Adicionar ao Carrinho";
            buttonAdicionarAoCarrinho.UseVisualStyleBackColor = true;
            buttonAdicionarAoCarrinho.Click += ButtonAdicionarAoCarrinho_Click;
            // 
            // dataGridViewCarrinho
            // 
            dataGridViewCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarrinho.Location = new System.Drawing.Point(12, 418);
            dataGridViewCarrinho.Name = "dataGridViewCarrinho";
            dataGridViewCarrinho.ReadOnly = true;
            dataGridViewCarrinho.Size = new System.Drawing.Size(360, 200);
            dataGridViewCarrinho.TabIndex = 2;
            // 
            // buttonFinalizarCompra
            // 
            buttonFinalizarCompra.Location = new System.Drawing.Point(378, 418);
            buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            buttonFinalizarCompra.Size = new System.Drawing.Size(150, 30);
            buttonFinalizarCompra.TabIndex = 3;
            buttonFinalizarCompra.Text = "Finalizar Compra";
            buttonFinalizarCompra.UseVisualStyleBackColor = true;
            buttonFinalizarCompra.Click += ButtonFinalizarCompra_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new System.Drawing.Point(378, 460);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new System.Drawing.Size(38, 15);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total:";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new System.Drawing.Point(422, 457);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new System.Drawing.Size(100, 23);
            textBoxTotal.TabIndex = 5;
            // 
            // FormPedido
            // 
            BackColor = System.Drawing.Color.LightGreen;
            ClientSize = new System.Drawing.Size(540, 630);
            Controls.Add(textBoxTotal);
            Controls.Add(labelTotal);
            Controls.Add(buttonFinalizarCompra);
            Controls.Add(dataGridViewCarrinho);
            Controls.Add(buttonAdicionarAoCarrinho);
            Controls.Add(dataGridViewProdutos);
            Name = "FormPedido";
            Text = "Fazer Pedido";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarrinho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
