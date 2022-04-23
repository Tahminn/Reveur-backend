using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class BookTag : BaseEntity
    {
        public Book Book { get; set; }
        public Tag Tag { get; set; }
    }
}
