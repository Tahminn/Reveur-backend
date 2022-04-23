using DomainLayer.Entities.BlogEntites;
using Microsoft.AspNetCore.Identity;

namespace DomainLayer.Entities.UserEntities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public ICollection<UserBookOrder> BookOrders { get; set; }
        public ICollection<UserBookComment> UserBookComments { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
