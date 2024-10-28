namespace UrbanFarming.Domain.Classes
{
    public class Pedido
    {
        public int CodigoPedido { get; set; }
        public double ValorTotal { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public Pedido() { 
        
        Itens = new List<ItemPedido>(); 
        }
    }
}
