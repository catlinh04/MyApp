using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Domain.Enums;

namespace MyApp.Application.DTOs.OrderDto.Responses
{
    public class OrderResponse
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public string Status { get; set; } = default!;
        public DateTime OrderDate { get; set; }
        public List<OrderItemResponse> Items { get; set; } = default!;
    }
}