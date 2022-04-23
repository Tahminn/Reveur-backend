using DomainLayer.Common;
using System.Linq.Expressions;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);

        Task<IEnumerable<T>> GetAllByConditionAsync(Expression<Func<T, bool>> predicate);

        Task<List<T>> GetAllAsync();

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}
