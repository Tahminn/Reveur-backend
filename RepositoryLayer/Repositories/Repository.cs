using DomainLayer.Common;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        internal readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            await _entities.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllByConditionAsync(Expression<Func<T, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        public async Task<List<T>> ReadAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Update(entity);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            _entities.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}
