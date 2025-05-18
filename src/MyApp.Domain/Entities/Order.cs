using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MyApp.Domain.Common;
using MyApp.Domain.Exception;

namespace MyApp.Domain.Entities
{
    public class Order : IEntity<Guid>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Enums.OrderStatus Status { get; set; } = Enums.OrderStatus.Pending;
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        public virtual ICollection<OrderItem> OrderItems { get; set; } = default!;


    }
}