using DomainLayer.Entities.BookEntities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces.BookEntitiesInterfaces;

namespace RepositoryLayer.Repositories.BookEntitiesRepositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly DbSet<Book> _books;

        public BookRepository(AppDbContext context) : base(context)
        {
            _books = _context.Set<Book>();
        }

        async Task<List<Book>> IBookRepository.GetAllAsync()
        {
            return await _books
                .Include(b => b.BookImages)
                .Include(b => b.BookAuthors)
                .ThenInclude(a => a.Author)
                .ToListAsync();
        }

        async Task<Book> IBookRepository.GetByIdAsync(int id)
        {
            return await _books.Where(b => b.Id == id)
                .Include(b => b.BlogBooks).ThenInclude(b => b.Blog)
                .Include(b => b.BookAuthors).ThenInclude(a => a.Author)
                .Include(b => b.BookGenres).ThenInclude(b => b.Genre)
                .Include(b => b.BookLanguages).ThenInclude(b => b.Language)
                .Include(b => b.BookTags).ThenInclude(b => b.Tag)
                .Include(b => b.Category).Include(b => b.BookDetails)
                .Include(b => b.BookImages)
                .FirstOrDefaultAsync();
        }
    }
}
