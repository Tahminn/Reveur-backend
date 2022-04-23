using DomainLayer.Common;
using DomainLayer.Entities.UserEntities;

namespace DomainLayer.Entities.BlogEntites
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Theme { get; set; }
        public string Image { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsApproved { get; set; }
        public AppUser AppUser { get; set; }
        public ICollection<BlogBook> BlogBooks { get; set; }
        public ICollection<UserBlogComment> UserBlogComments { get; set; }
    }
}
