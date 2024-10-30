namespace UrbanFarmingDesktop.UI
{
    partial class FormPedido
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewPedidos;

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
            dataGridViewPedidos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewPedidos)).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPedidos
            // 
            dataGridViewPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPedidos.Location = new Point(12, 12);
            dataGridViewPedidos.Name = "dataGridViewPedidos";
            dataGridViewPedidos.ReadOnly = true;
            dataGridViewPedidos.RowTemplate.Height = 25;
            dataGridViewPedidos.Size = new Size(760, 400);
            dataGridViewPedidos.TabIndex = 0;
            // 
            // FormPedido
            // 
            ClientSize = new Size(784, 461);
            Controls.Add(dataGridViewPedidos);
            Name = "FormPedido";
            Text = "Pedidos Feitos";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewPedidos)).EndInit();
            ResumeLayout(false);
        }
    }
}
