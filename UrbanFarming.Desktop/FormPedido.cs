using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UrbanFarmingDesktop.UI
{
    public partial class FormPedido : Form
    {
        public FormPedido()
        {
            InitializeComponent();
            CarregarPedidos();
        }

        private void CarregarPedidos()
        {
            var pedidos = ObterPedidos();
            dataGridViewPedidos.DataSource = pedidos;
        }

        private List<Pedido> ObterPedidos()
        {
            return new List<Pedido>
            {
                new Pedido { CodigoPedido = 101, ValorTotal = 250.75m, Usuario = "usuario1", Data = DateTime.Parse("2024-10-10"), IdItem = 1 },
                new Pedido { CodigoPedido = 102, ValorTotal = 150.00m, Usuario = "usuario2", Data = DateTime.Parse("2024-10-11"), IdItem = 2 },
                new Pedido { CodigoPedido = 103, ValorTotal = 320.50m, Usuario = "usuario3", Data = DateTime.Parse("2024-10-12"), IdItem = 3 },
                new Pedido { CodigoPedido = 104, ValorTotal = 99.99m, Usuario = "usuario4", Data = DateTime.Parse("2024-10-13"), IdItem = 4 }
            };
        }
    }

    public class Pedido
    {
        public int CodigoPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public int IdItem { get; set; }
    }
}
