using DomainLayer.Entities.BookEntities;

namespace RepositoryLayer.Repositories.Interfaces.BookEntitiesInterfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
    }
}