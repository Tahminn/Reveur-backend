using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class BookImage : BaseEntity
    {
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public Book Book { get; set; }
    }
}
