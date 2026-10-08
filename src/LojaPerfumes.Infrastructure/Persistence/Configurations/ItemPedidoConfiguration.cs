using LojaPerfumes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaPerfumes.Infrastructure.Persistence.Configurations;

public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
{
    public void Configure(EntityTypeBuilder<ItemPedido> builder)
    {
        builder.ToTable("ItensPedido");
        builder.HasKey(i => i.ItemPedidoId);
        builder.Property(i => i.ItemPedidoId).ValueGeneratedNever();
        builder.Property(i => i.Quantidade).IsRequired();

        builder.HasOne(i => i.Pedido)
            .WithMany(p => p.Itens)
            .HasForeignKey(i => i.PedidoId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(i => i.Perfume)
            .WithMany(p => p.ItensPedido)
            .HasForeignKey(i => i.PerfumeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        
        builder.HasIndex(i => new { i.PedidoId, i.PerfumeId }).IsUnique();
    }
}