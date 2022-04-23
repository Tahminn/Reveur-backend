using DomainLayer.Common;
using DomainLayer.Entities.BookEntities;

namespace DomainLayer.Entities.UserEntities
{
    public class UserBookOrder : BaseEntity
    {
        public AppUser AppUser { get; set; }
        public Book Book { get; set; }
        public Order Order { get; set; }
    }
}
