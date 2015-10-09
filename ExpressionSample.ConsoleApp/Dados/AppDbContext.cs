using ExpressionSample.ConsoleApp.Dados.Configurations;
using ExpressionSample.ConsoleApp.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionSample.ConsoleApp.Dados
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base()
        {

        }

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new PedidoConfiguration());
        }


    }
}
