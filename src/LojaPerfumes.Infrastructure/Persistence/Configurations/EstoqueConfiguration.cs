using LojaPerfumes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaPerfumes.Infrastructure.Persistence.Configurations;

public class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
{
    public void Configure(EntityTypeBuilder<Estoque> builder)
    {
        builder.ToTable("Estoques");
        builder.HasKey(e => e.EstoqueId);
        builder.Property(e => e.EstoqueId).ValueGeneratedNever();
        builder.Property(e => e.Quantidade).IsRequired();

        builder.HasOne(e => e.Perfume)
            .WithOne(p => p.Estoque)
            .HasForeignKey<Estoque>(e => e.PerfumeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        
        
        builder.HasIndex(e => e.PerfumeId).IsUnique();
    }
}