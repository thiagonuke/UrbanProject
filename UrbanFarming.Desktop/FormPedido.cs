using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UrbanFarmingWeb.UI.Request;
using UrbanFarming.Domain.Classes;

namespace UrbanFarmingDesktop.UI
{
    public partial class FormPedido : Form
    {
        private readonly RequestAPI _requestAPI;
        private List<Produtos> _produtos;
        private List<Produtos> _carrinho;

        public FormPedido()
        {
            InitializeComponent();
            var httpClient = new HttpClient();
            _requestAPI = new RequestAPI(httpClient);
            _carrinho = new List<Produtos>();
            CarregarProdutos();
        }

        private async void CarregarProdutos()
        {
            try
            {
                _produtos = await _requestAPI.ListaProdutos();
                dataGridViewProdutos.DataSource = _produtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }

        private void ButtonAdicionarAoCarrinho_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.CurrentRow != null)
            {
                var produtoSelecionado = (Produtos)dataGridViewProdutos.CurrentRow.DataBoundItem;
                _carrinho.Add(produtoSelecionado);
                dataGridViewCarrinho.DataSource = _carrinho.ToList();
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Selecione um produto para adicionar ao carrinho.");
            }
        }

        private void CalcularTotal()
        {
            decimal total = _carrinho.Sum(p => p.Valor);
            textBoxTotal.Text = total.ToString("C2");
        }

        private async void ButtonFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (_carrinho.Count == 0)
            {
                MessageBox.Show("O carrinho está vazio.");
                return;
            }

            var pedido = new Pedido
            {
                // Aqui você pode definir como está montando o pedido
                // Ex: ValorTotal, Usuario, etc.
            };

            try
            {
                var response = await _requestAPI.EfetuarCadastradoPedido(pedido);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Compra finalizada com sucesso!");
                    _carrinho.Clear();
                    dataGridViewCarrinho.DataSource = null;
                    textBoxTotal.Clear();
                }
                else
                {
                    MessageBox.Show($"Erro ao finalizar compra: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}
