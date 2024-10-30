using Microsoft.EntityFrameworkCore;
using UrbanFarming.Data.Context;
using UrbanFarming.Domain.Classes;
using UrbanFarming.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UrbanFarming.Data.Repositories
{
    public class PedidosRepository : IPedidosRepository
    {
        private readonly UrbanContext _context;

        public PedidosRepository(UrbanContext context)
        {
            _context = context;
        }

        public async Task<Pedido> GetByCodigo(int codigo) 
        {
            return await _context.PedidoLst.Include(p => p.Itens) 
                .FirstOrDefaultAsync(u => u.CodigoPedido == codigo);
        }

        public async Task<List<Pedido>> GetAllPedidos()
        {
            try
            {
                return await _context.PedidoLst.Include(p => p.Itens)
              .ToListAsync();
            }
            catch(Exception ex) { return null; }
          
        }

        public async Task<bool> PostPedido(Pedido pedido)
        {
            try
            {
                var id = 0;

                if (_context.Pedidos.Any())
                {

                    id = _context.Pedidos.Max(p => p.CodigoPedido) + 1;
                }
                pedido.CodigoPedido = id;


                await _context.Pedidos.AddAsync(new Pedidos()
                {
                    CodigoPedido = pedido.CodigoPedido,
                    ValorTotal = pedido.ValorTotal,
                    Usuario  = pedido.Usuario,  
                    Data = pedido.Data  

                });
                await _context.SaveChangesAsync();

                foreach (var i in pedido.Itens)
                {
                    i.CodigoPedido = id;


                    await _context.ItensPedido.AddAsync(i);

                    await _context.SaveChangesAsync();
                }


                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro: {ex.Message}");
            }
        }

        public async Task<bool> PutPedido(Pedido pedido)
        {
            try
            {
                var existingPedido = await _context.PedidoLst.Include(p => p.Itens).FirstOrDefaultAsync(p => p.CodigoPedido == pedido.CodigoPedido);

                if (existingPedido == null)
                {
                    return false;
                }

                existingPedido.ValorTotal = pedido.ValorTotal;
                existingPedido.Usuario = pedido.Usuario;
                existingPedido.Data = pedido.Data;

                _context.ItensPedido.RemoveRange(existingPedido.Itens); 
                existingPedido.Itens = pedido.Itens; 

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro: {ex.Message}");
            }
        }

        public async Task<bool> DeletePedido(int codigo) 
        {
            try
            {
                var pedido = await _context.PedidoLst.Include(p => p.Itens).FirstOrDefaultAsync(p => p.CodigoPedido == codigo);

                if (pedido == null)
                    return false;

                _context.ItensPedido.RemoveRange(pedido.Itens); 
                //_context.Pedidos.Remove(pedido);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}
