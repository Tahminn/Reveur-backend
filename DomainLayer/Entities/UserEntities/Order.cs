using DomainLayer.Common;
using DomainLayer.Enums;

namespace DomainLayer.Entities.UserEntities
{
    public class Order : BaseEntity
    {
        public string Number { get; set; }
        public float? TotalPrice { get; set; }
        public DateTime DateCreated { get; set; }
        public OrderStatus Status { get; set; }
        public ICollection<UserBookOrder> BookOrders { get; set; }
    }
}
