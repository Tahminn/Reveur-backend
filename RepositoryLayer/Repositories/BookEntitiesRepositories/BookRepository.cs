using DomainLayer.Entities.BookEntities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces.BookEntitiesInterfaces;

namespace RepositoryLayer.Repositories.BookEntitiesRepositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Book> _books;

        public BookRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _books = _context.Set<Book>();
        }

        async Task<List<Book>> IBookRepository.GetAllBooksWithAuthorsAndImagesAsync()
        {
            var a = await _books
                .Include(b => b.BookAuthors)
                .ThenInclude(a => a.Author)
                .Include(b => b.BookImages)
                .ToListAsync();
            return a;
        }
    }
}
