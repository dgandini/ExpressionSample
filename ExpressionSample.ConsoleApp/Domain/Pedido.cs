using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionSample.ConsoleApp.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Decimal Valor { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// Regra: pedidos em aberto com mais de dez dias são considerados como "vencidos"
        /// </summary>
        /// <returns></returns>
        internal static Expression<Func<Pedido, bool>> PedidosVencidosFilter()
        {
            var dataLimite = DateTime.Now.AddDays(-10); 
            Expression<Func<Pedido, bool>> retorno = x => x.Data <= dataLimite && x.Status.Equals("Novo");
            return retorno;
        }

        public bool Vencido()
        {
            return PedidosVencidosFilter().Compile().Invoke(this);
        }
    }
}
