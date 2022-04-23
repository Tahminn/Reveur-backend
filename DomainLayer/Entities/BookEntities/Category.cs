using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<Book> Books { get; set; }
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; }
    }
}
