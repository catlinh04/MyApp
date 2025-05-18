using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Application.DTOs.Pagination.Request;
using MyApp.Application.DTOs.Pagination.Responses;
using MyApp.Domain.Entities;

namespace MyApp.Application.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order, Guid>
    {
        Task<Order?> GetByIdAsync(Guid id);
        Task<PaginationData<Order>> ListAllAsync(PaginationRequest request);
    }
}