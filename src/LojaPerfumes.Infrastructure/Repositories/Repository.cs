using LojaPerfumes.Application.Interfaces;
using LojaPerfumes.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LojaPerfumes.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly LojaPerfumesContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(LojaPerfumesContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T?> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);

    public async Task<IReadOnlyList<T>> GetAllAsync() => await _dbSet.AsNoTracking().ToListAsync();

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}