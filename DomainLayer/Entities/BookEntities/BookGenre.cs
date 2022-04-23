using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class BookGenre : BaseEntity
    {
        public Book Book { get; set; }
        public Genre Genre { get; set; }
    }
}
