using DomainLayer.Entities.BookEntities;

namespace RepositoryLayer.Repositories.Interfaces.BookEntitiesInterfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<List<Book>> GetAllBooksWithAuthorsAndImagesAsync();
    }
}