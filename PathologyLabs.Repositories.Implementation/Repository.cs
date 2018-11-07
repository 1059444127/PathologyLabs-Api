using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories.Implementation
{
    public class Repository<TDomain, TPrimaryKey> : IRepository<TDomain, TPrimaryKey>
        where TDomain : Entity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        private Func<Task<EntityEntry<TDomain>>, bool, Task<TDomain>> _executor;

        protected PathologyLabsDbContext Context { get; private set; }

        protected Repository(PathologyLabsDbContext context)
        {
            this.Context = context;
            this._executor = async (Task<EntityEntry<TDomain>> action, bool isSaveTransaction) =>
            {
                try
                {
                    TDomain execEntity = (await action.ConfigureAwait(false))?.Entity;

                    if (isSaveTransaction && execEntity != null)
                    {
                        await this.Context.SaveChangesAsync().ConfigureAwait(false);
                    }

                    return execEntity;
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            };
        }

        public virtual async Task<TDomain> CreateAsync(TDomain entity)
        {
            return await this._executor(this.Context.AddAsync<TDomain>(entity), true).ConfigureAwait(false);
        }

        public virtual async Task<TDomain> DeleteAsync(TDomain entity)
        {
            return await this._executor(Task.FromResult(this.Context.Remove<TDomain>(entity)), true).ConfigureAwait(false);
        }

        public virtual async Task<IQueryable<TDomain>> GetAllAsync()
        {
            return await Task.FromResult(this.Context.Set<TDomain>()).ConfigureAwait(false);
        }

        public virtual async Task<TDomain> GetAsync(TPrimaryKey id)
        {
            return await this.Context.FindAsync<TDomain>(id).ConfigureAwait(false);
        }

        public virtual async Task<TDomain> UpdateAsync(TDomain entity)
        {
            this.Context.Patients.Include(patient => patient.Reports);
            return await this._executor(Task.FromResult(this.Context.Update<TDomain>(entity)), true).ConfigureAwait(false);
        }

        public virtual async Task<IQueryable<TDomain>> GetAllIncludingAsync(params Expression<Func<TDomain, object>>[] propertySelectors)
        {
            IQueryable<TDomain> query = this.Context.Set<TDomain>().AsQueryable();
            propertySelectors?.ToList()?.ForEach(s => query = query.Include(s));
            return await Task.FromResult(query).ConfigureAwait(false);
        }
    }
}
