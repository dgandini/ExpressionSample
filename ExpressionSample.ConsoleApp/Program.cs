using ExpressionSample.ConsoleApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionSample.ConsoleApp
{
    class Program
    {
        private readonly PedidoService _pedidoService;

        public Program()
        {
            _pedidoService = new PedidoService();
        }

        public void Executar()
        {
            var pedidosVencidos = _pedidoService.GetPedidosPrazoVencido();
            
            Console.WriteLine("Pedidos Vencidos:");
            Console.WriteLine("#\tData\tValor\tStatus\tVencido:");
            foreach(var pedido in pedidosVencidos)
            {
                Console.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}", 
                    pedido.Id,
                    pedido.Data,
                    pedido.Valor,
                    pedido.Status,
                    pedido.Vencido()));
            }

        }

        static void Main(string[] args)
        {
            var p = new Program();
            p.Executar();

            Console.ReadKey();
        }
    }
}
