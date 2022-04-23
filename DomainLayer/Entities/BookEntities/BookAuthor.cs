using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class BookAuthor : BaseEntity
    {
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
