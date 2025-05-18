using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.OrderDto.Responses
{
    public class OrderItemResponse
    {
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}