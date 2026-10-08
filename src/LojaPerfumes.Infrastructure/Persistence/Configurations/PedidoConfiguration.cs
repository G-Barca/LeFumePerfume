using LojaPerfumes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaPerfumes.Infrastructure.Persistence.Configurations;

public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.ToTable("Pedidos");
        builder.HasKey(p => p.PedidoId);
        builder.Property(p => p.PedidoId).ValueGeneratedNever();
        builder.Property(p => p.DataPedido).IsRequired();
        builder.Property(p => p.StatusPedido).IsRequired().HasMaxLength(50);

        builder.HasOne(p => p.Cliente)
            .WithMany(c => c.Pedidos)
            .HasForeignKey(p => p.ClienteId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}