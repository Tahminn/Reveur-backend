using DomainLayer.Common;
using DomainLayer.Entities.BookEntities;

namespace DomainLayer.Entities.BlogEntites
{
    public class BlogBook : BaseEntity
    {
        public Blog Blog { get; set; }
        public Book Book { get; set; }
        public string BookContent { get; set; }
    }
}
