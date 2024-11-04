using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrbanFarming.Domain.Classes;
using UrbanFarmingWeb.UI.Request;

namespace UrbanFarmingDesktop.UI
{
    public partial class FormListaPedidos : Form
    {
        private readonly RequestAPI _requestAPI;

        public FormListaPedidos()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            _requestAPI = new RequestAPI(httpClient);
            CarregarPedidos();
        }

        private async void CarregarPedidos()
        {
            var pedidos = await ObterPedidos();
            dataGridViewPedidos.DataSource = pedidos;
        }

        private async Task<List<Pedido>> ObterPedidos()
        {
            // Chama a API para obter a lista de pedidos
            return await _requestAPI.ListaPedidos();
        }
    }
}
