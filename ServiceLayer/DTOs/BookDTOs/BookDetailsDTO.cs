
using DomainLayer.Entities.BlogEntites;
using DomainLayer.Entities.BookEntities;
using DomainLayer.Entities.UserEntities;

namespace ServiceLayer.DTOs.BookDTOs
{
    public class BookDetailsDTO
    {
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
        public int UnitsSold { get; set; }
        public int UnitsQuantity { get; set; }
        public string Excerpt { get; set; }
        public string ContentsTable { get; set; }
        public CategoryDTO Category { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; }
        public ICollection<BookImageDTO> BookImages { get; set; }
        public ICollection<TagDTO> BookTags { get; set; }
        public ICollection<GenreDTO> BookGenres { get; set; }
        public ICollection<LanguageDTO> BookLanguages { get; set; }
    }
}
