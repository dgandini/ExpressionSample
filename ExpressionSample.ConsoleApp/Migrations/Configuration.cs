namespace ExpressionSample.ConsoleApp.Migrations
{
    using ExpressionSample.ConsoleApp.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExpressionSample.ConsoleApp.Dados.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ExpressionSample.ConsoleApp.Dados.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Pedidos.AddOrUpdate(
                p => p.Id,
                new Pedido { Id = 1, Data = DateTime.Now, Valor = 100, Status = "Cancelado" },
                new Pedido { Id = 2, Data = DateTime.Now.AddDays(-15), Valor = 120, Status = "Novo" },
                new Pedido { Id = 3, Data = DateTime.Now.AddDays(-20), Valor = 180, Status = "Entregue" },
                new Pedido { Id = 3, Data = DateTime.Now.AddDays(-5), Valor = 1100, Status = "Excluido" },
                new Pedido { Id = 3, Data = DateTime.Now.AddDays(-10), Valor = 200, Status = "Novo" },
                new Pedido { Id = 3, Data = DateTime.Now.AddDays(-2), Valor = 800, Status = "Novo" }
                );

        }
    }
}
