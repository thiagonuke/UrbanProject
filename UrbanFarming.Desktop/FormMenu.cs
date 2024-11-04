using System;
using System.Windows.Forms;
using UrbanFarmingDesktop.UI;

namespace UrbanFarming.Desktop
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            FormProduto formProduto = new FormProduto();
            formProduto.Show();
        }

        private void buttonPedido_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            formPedido.Show();
        }

        private void buttonListaPedidos_Click(object sender, EventArgs e)
        {
            FormListaPedidos formListaPedidos = new FormListaPedidos();
            formListaPedidos.Show();
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            FormFornecedor formFornecedor = new FormFornecedor();
            formFornecedor.Show();
        }
    }
}
