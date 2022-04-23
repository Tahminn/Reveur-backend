using DomainLayer.Common;

namespace DomainLayer.Entities.BookEntities
{
    public class Language : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
