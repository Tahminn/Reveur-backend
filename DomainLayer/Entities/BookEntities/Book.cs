using DomainLayer.Common;
using DomainLayer.Entities.BlogEntites;
using DomainLayer.Entities.UserEntities;

namespace DomainLayer.Entities.BookEntities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public Category Category { get; set; }
        public BookDetails BookDetails { get; set; }
        public ICollection<BookImage> BookImages { get; set; }
        public ICollection<BookTag> BookTags { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }
        public ICollection<BookLanguage> BookLanguages { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<UserBookOrder> BookOrders { get; set; }
        public ICollection<UserBookComment> UserBookComments { get; set; }
        public ICollection<UserBlogComment> UserBlogComments { get; set; }
        public ICollection<BlogBook> BlogBooks { get; set; }
    }
}
