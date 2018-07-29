using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Core;
using PathologyLabs.Repositories;

namespace PathologyLabs.Services
{
    public abstract class Service<TDomain, TApiModel> : Service<TDomain, TApiModel, int>
        where TDomain : Entity
        where TApiModel : ApiModel
    {
        protected Service(IRepository<TDomain, int> repository) : base(repository)
        {
        }
    }

    public abstract class Service<TDomain, TApiModel, TPrimaryKey> : IService<TDomain, TApiModel, TPrimaryKey>
        where TDomain : Entity<TPrimaryKey>
        where TApiModel : ApiModel<TPrimaryKey>
        where TPrimaryKey : struct
    {
        private readonly IRepository<TDomain, TPrimaryKey> _repository;

        protected Service(IRepository<TDomain, TPrimaryKey> repository)
        {
            this._repository = repository;
        }

        public virtual async Task<TApiModel> CreateAsync(TApiModel model)
        {
            TDomain entity = await this._repository.CreateAsync(Mapper.Map<TDomain>(model)).ConfigureAwait(false);
            return Mapper.Map<TApiModel>(entity);
        }

        public virtual async Task<TApiModel> DeleteAsync(TApiModel model)
        {
            TDomain entity = await this._repository.DeleteAsync(Mapper.Map<TDomain>(model)).ConfigureAwait(false);
            return Mapper.Map<TApiModel>(entity);
        }

        public virtual async Task<IEnumerable<TApiModel>> GetAllAsync()
        {
            IEnumerable<TDomain> entities = await this._repository.GetAllAsync().ConfigureAwait(false);
            return Mapper.Map<IEnumerable<TApiModel>>(entities);
        }

        public virtual async Task<TApiModel> GetAsync(TPrimaryKey id)
        {
            TDomain entity = await this._repository.GetAsync(id).ConfigureAwait(false);
            return Mapper.Map<TApiModel>(entity);
        }

        public virtual async Task<TApiModel> UpdateAsync(TApiModel model)
        {
            TDomain entity = await this._repository.UpdateAsync(Mapper.Map<TDomain>(model)).ConfigureAwait(false);
            return Mapper.Map<TApiModel>(entity);
        }
    }
}
