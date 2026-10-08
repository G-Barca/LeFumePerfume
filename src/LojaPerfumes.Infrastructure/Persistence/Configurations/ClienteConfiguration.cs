using LojaPerfumes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LojaPerfumes.Infrastructure.Persistence.Configurations;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");
        builder.HasKey(c => c.ClienteId);
        builder.Property(c => c.ClienteId).ValueGeneratedNever();
        builder.Property(c => c.Nome).IsRequired().HasMaxLength(150);
        builder.Property(c => c.Email).IsRequired().HasMaxLength(200);
        builder.HasIndex(c => c.Email).IsUnique();
    }
}