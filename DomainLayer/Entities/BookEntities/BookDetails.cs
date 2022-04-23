using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class BookDetails : BaseEntity
    {
        public string Publisher { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
        public int UnitsSold { get; set; }
        public int UnitsQuantity { get; set; }
        public string Excerpt { get; set; }
        public string ContentsTable { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
