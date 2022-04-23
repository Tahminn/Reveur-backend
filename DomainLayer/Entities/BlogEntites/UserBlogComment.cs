using DomainLayer.Common;
using DomainLayer.Entities.UserEntities;

namespace DomainLayer.Entities.BlogEntites
{
    public class UserBlogComment : BaseEntity
    {
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public int Rated { get; set; }
        public AppUser AppUser { get; set; }
        public Blog Blog { get; set; }
    }
}
