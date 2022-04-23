using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class BookLanguage : BaseEntity
    {
        public Book Book { get; set; }
        public Language Language { get; set; }
    }
}
