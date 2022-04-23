using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
