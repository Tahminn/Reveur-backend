using DomainLayer.Common;
using DomainLayer.Entities.BookEntities;

namespace DomainLayer.Entities.UserEntities
{
    public class UserBookComment : BaseEntity
    {
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public int Rated { get; set; }
        public AppUser AppUser { get; set; }
        public Book Book { get; set; }
    }
}
