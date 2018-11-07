using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories
{
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : Entity
    {
    }

    public interface IRepository<TEntity, TPrimaryKey> where TEntity : Entity<TPrimaryKey> where TPrimaryKey : struct
    {
        Task<TEntity> GetAsync(TPrimaryKey id);

        Task<IQueryable<TEntity>> GetAllAsync();

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<TEntity> DeleteAsync(TEntity entity);

        Task<IQueryable<TEntity>> GetAllIncludingAsync(params Expression<Func<TEntity, object>>[] propertySelectors);
    }
}
