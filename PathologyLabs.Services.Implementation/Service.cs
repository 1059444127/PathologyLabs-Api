using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Core;
using PathologyLabs.Repositories;

namespace PathologyLabs.Services.Implementation
{
    public class Service<TDomain, TApiModel> : Service<TDomain, TApiModel, int>
        where TDomain : Entity
        where TApiModel : ApiModel
    {
        protected Service(IRepository<TDomain, int> repository) : base(repository)
        {
        }
    }

    public class Service<TDomain, TApiModel, TPrimaryKey> : IService<TDomain, TApiModel, TPrimaryKey>
        where TDomain : Entity<TPrimaryKey>
        where TApiModel : ApiModel<TPrimaryKey>
        where TPrimaryKey : struct
    {
        protected IRepository<TDomain, TPrimaryKey> Repository { get; private set; }

        protected Service(IRepository<TDomain, TPrimaryKey> repository)
        {
            this.Repository = repository;
        }

        public virtual async Task<TApiModel> CreateAsync(TApiModel model)
        {
            TDomain entity = await this.Repository.CreateAsync(Mapper.Map<TDomain>(model)).ConfigureAwait(false);
            return Mapper.Map<TApiModel>(entity);
        }

        public virtual async Task<TApiModel> DeleteAsync(TApiModel model)
        {
            TDomain entity = await this.Repository.DeleteAsync(Mapper.Map<TDomain>(model)).ConfigureAwait(false);
            return Mapper.Map<TApiModel>(entity);
        }

        public virtual async Task<IEnumerable<TApiModel>> GetAllAsync()
        {
            IEnumerable<TDomain> entities = await this.Repository.GetAllAsync().ConfigureAwait(false);
            return Mapper.Map<IEnumerable<TApiModel>>(entities);
        }

        public virtual async Task<TApiModel> GetAsync(TPrimaryKey id)
        {
            TDomain entity = await this.Repository.GetAsync(id).ConfigureAwait(false);
            return Mapper.Map<TApiModel>(entity);
        }

        public virtual async Task<TApiModel> UpdateAsync(TApiModel model)
        {
            TDomain entity = await this.Repository.UpdateAsync(Mapper.Map<TDomain>(model)).ConfigureAwait(false);
            return Mapper.Map<TApiModel>(entity);
        }
    }
}
