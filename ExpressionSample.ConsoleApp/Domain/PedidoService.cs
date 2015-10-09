using ExpressionSample.ConsoleApp.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionSample.ConsoleApp.Domain
{
    class PedidoService
    {
        private readonly GenericRepository<Pedido> _pedidoRepository;
        private readonly AppDbContext _context;

        public PedidoService()
        {
            _context = new AppDbContext();
            _pedidoRepository = new GenericRepository<Pedido>(_context);
        }

        public IEnumerable<Pedido> GetPedidosPrazoVencido()
        {
            return _pedidoRepository.Get(filter: Pedido.PedidosVencidosFilter());
        }

    }
}
