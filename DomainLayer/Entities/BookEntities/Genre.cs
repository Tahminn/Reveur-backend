using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }
    }
}
