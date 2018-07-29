using System.Collections.Generic;
using System.Threading.Tasks;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Core;

namespace PathologyLabs.Services
{
    public interface IService<TDomain, TApiModel> : IService<TDomain, TApiModel, int>
        where TDomain : Entity
        where TApiModel : ApiModel
    {
    }

    public interface IService<TDomain, TApiModel, TPrimaryKey> 
        where TDomain : Entity<TPrimaryKey>
        where TApiModel : ApiModel<TPrimaryKey>
        where TPrimaryKey : struct
    {
        Task<TApiModel> GetAsync(TPrimaryKey id);

        Task<IEnumerable<TApiModel>> GetAllAsync();

        Task<TApiModel> CreateAsync(TApiModel model);

        Task<TApiModel> UpdateAsync(TApiModel model);

        Task<TApiModel> DeleteAsync(TApiModel model);
    }
}
