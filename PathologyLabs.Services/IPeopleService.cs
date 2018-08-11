using System.Collections.Generic;
using System.Threading.Tasks;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Core;

namespace PathologyLabs.Services 
{
    public interface IPeopleService<TDomain, TApiModel> : IPeopleService<TDomain, TApiModel, int>
        where TDomain : Person<int>
        where TApiModel : PersonApiModel<int>
    {
    }

    public interface IPeopleService<TDomain, TApiModel, TPrimaryKey> : IService<TDomain, TApiModel, TPrimaryKey>
        where TDomain : Person<TPrimaryKey>
        where TApiModel : PersonApiModel<TPrimaryKey>
        where TPrimaryKey : struct
    {
        Task<IEnumerable<TApiModel>> GetPeopleByNameAsync(string firstName);

        Task<IEnumerable<TApiModel>> GetPeopleByLastNameAsync(string lastName);

        Task<TApiModel> GetPersonByEmailAsync(string email);

        Task<TApiModel> GetPersonByPhoneNumberAsync(string phoneNumber);

        Task<IEnumerable<TApiModel>> FilterPeopleByAsync(string firstName = null, string lastName = null, string email = null, string phoneNumber = null, string address = null);
    }
}