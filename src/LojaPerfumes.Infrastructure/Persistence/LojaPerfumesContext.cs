using LojaPerfumes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LojaPerfumes.Infrastructure.Persistence;

public class LojaPerfumesContext : DbContext
{
    public LojaPerfumesContext(DbContextOptions<LojaPerfumesContext> options) : base(options) { }

    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Pedido> Pedidos => Set<Pedido>();
    public DbSet<ItemPedido> ItensPedido => Set<ItemPedido>();
    public DbSet<Perfume> Perfumes => Set<Perfume>();
    public DbSet<Categoria> Categorias => Set<Categoria>();
    public DbSet<Estoque> Estoques => Set<Estoque>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Carrega automaticamente todas as classes IEntityTypeConfiguration<T> da Infrastructure
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LojaPerfumesContext).Assembly);
    }
}