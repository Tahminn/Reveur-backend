using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<BookTag> BookTags { get; set; }
    }
}
