using ExpressionSample.ConsoleApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionSample.ConsoleApp.Dados.Configurations
{
    class PedidoConfiguration : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfiguration()
        {
            ToTable("Pedido");
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("IdPedido")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Data)
                .HasColumnName("DataPedido")
                .IsRequired();

            Property(x => x.Valor)
                .HasColumnName("ValorPedido")
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName("StatusPedido")
                .HasMaxLength(20)
                .IsRequired();

        }
    }
}
