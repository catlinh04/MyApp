using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Domain.Common;

namespace MyApp.Application.Interfaces
{
    public interface IGenericRepository<TEntity, TKey>
    where TEntity : IEntity<TKey>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task SaveChangesAsync();
    }

}