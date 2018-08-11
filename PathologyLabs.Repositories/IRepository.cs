using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories
{
    public interface IRepository<TDomain> : IRepository<TDomain, int> where TDomain : Entity
    {
    }

    public interface IRepository<TDomain, TPrimaryKey> where TDomain : Entity<TPrimaryKey> where TPrimaryKey : struct
    {
        Task<TDomain> GetAsync(TPrimaryKey id);

        Task<IQueryable<TDomain>> GetAllAsync();

        Task<TDomain> CreateAsync(TDomain entity);

        Task<TDomain> UpdateAsync(TDomain entity);

        Task<TDomain> DeleteAsync(TDomain entity);

        Task<IQueryable<TDomain>> GetAllIncludingAsync(params Expression<Func<TDomain, object>>[] propertySelectors);
    }
}
