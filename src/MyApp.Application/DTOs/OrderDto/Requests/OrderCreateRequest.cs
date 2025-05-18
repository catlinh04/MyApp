using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Domain.Enums;

namespace MyApp.Application.DTOs.OrderDto.Requests
{
    public class OrderCreateRequest
    {
        public List<OrderItemRequest> Items { get; set; } = new List<OrderItemRequest>();
    }
}