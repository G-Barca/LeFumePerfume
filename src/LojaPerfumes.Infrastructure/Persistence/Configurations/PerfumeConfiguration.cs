using LojaPerfumes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaPerfumes.Infrastructure.Persistence.Configurations;

public class PerfumeConfiguration : IEntityTypeConfiguration<Perfume>
{
    public void Configure(EntityTypeBuilder<Perfume> builder)
    {
        builder.ToTable("Perfumes");
        builder.HasKey(p => p.PerfumeId);
        builder.Property(p => p.PerfumeId).ValueGeneratedNever();
        builder.Property(p => p.Nome).IsRequired().HasMaxLength(150);
        builder.Property(p => p.Preco).IsRequired().HasPrecision(10, 2);

        builder.HasOne(p => p.Categoria)
            .WithMany(c => c.Perfumes)
            .HasForeignKey(p => p.CategoriaId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);
    }
}