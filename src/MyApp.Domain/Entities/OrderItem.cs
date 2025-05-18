using System;
using MyApp.Domain.Common;
using MyApp.Domain.Exception;

namespace MyApp.Domain.Entities
{
    public class OrderItem : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }


        // FK 
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; } = default!;

        // FK
        public Guid ItemId { get; set; }
        public virtual Item Item { get; set; } = default!;


    }
}
