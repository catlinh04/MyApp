using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Application.DTOs.Pagination;
using MyApp.Application.DTOs.Pagination.Request;
using MyApp.Application.DTOs.Pagination.Responses;

namespace MyApp.Application.Interfaces
{
    public interface IPaginationRepository<TEntity, in TKey>
    {
        Task<PaginationData<TEntity>> ListPagedAsync(
            PaginationRequest paging);
    }
}