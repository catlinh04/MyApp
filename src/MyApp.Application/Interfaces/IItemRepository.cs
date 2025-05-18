using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Application.DTOs.OrderDto.Requests;
using MyApp.Application.DTOs.Pagination.Request;
using MyApp.Application.DTOs.Pagination.Responses;
using MyApp.Domain.Entities;

namespace MyApp.Application.Interfaces
{
    public interface IItemRepository : IGenericRepository<Item, Guid>
    {
        Task<Item?> GetByIdAsync(Guid id);
        Task<PaginationData<Item>> ListAllAsync(PaginationRequest request);
        Task<List<Item>> GetByIdsAsync(List<Guid> ids);
        Task<Guid?> GetFirstInsufficientStockItemIdAsync(
            List<OrderItemRequest> items);
    }
}