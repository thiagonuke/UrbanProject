using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UrbanFarming.Domain.Classes
{
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoPedido { get; set; }
        public double ValorTotal { get; set; }
        public string Usuario { get; set; }
        public DateTime Data { get; set; }
        public List<ItensPedido> Itens { get; set; }

        public Pedido() { 
        
        Itens = new List<ItensPedido>(); 
        }
    }
}
