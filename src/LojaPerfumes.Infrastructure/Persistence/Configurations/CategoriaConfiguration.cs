using LojaPerfumes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaPerfumes.Infrastructure.Persistence.Configurations;

public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
{
    public void Configure(EntityTypeBuilder<Categoria> builder)
    {
        builder.ToTable("Categorias");
        builder.HasKey(c => c.CategoriaId);
        builder.Property(c => c.CategoriaId).ValueGeneratedNever();
        builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
        builder.HasIndex(c => c.Nome).IsUnique();
    }
}