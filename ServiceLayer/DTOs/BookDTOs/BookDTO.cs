using DomainLayer.Entities.BookEntities;

namespace ServiceLayer.DTOs.BookDTOs
{
    public class BookDTO
    {
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public decimal? OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<BookImageDTO> BookImages { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; }
    }
}
