using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Core;
using PathologyLabs.Repositories;

namespace PathologyLabs.Services
{
    public class PeopleService<TDomain, TApiModel> : PeopleService<TDomain, TApiModel, int>
        where TDomain : Person
        where TApiModel : PersonApiModel
    {
        public PeopleService(IRepository<TDomain, int> repository) : base(repository)
        {
        }
    }

    public class PeopleService<TDomain, TApiModel, TPrimaryKey> : Service<TDomain, TApiModel, TPrimaryKey>, IPeopleService<TDomain, TApiModel, TPrimaryKey>
        where TDomain : Person<TPrimaryKey>
        where TApiModel : PersonApiModel<TPrimaryKey>
        where TPrimaryKey : struct
    {
        public PeopleService(IRepository<TDomain, TPrimaryKey> repository) : base(repository)
        {
        }

        public virtual async Task<IEnumerable<TApiModel>> GetPeopleByNameAsync(string firstName) => await this.FilterPeopleByAsync(firstName: firstName).ConfigureAwait(false);

        public virtual async Task<IEnumerable<TApiModel>> GetPeopleByLastNameAsync(string lastName) => await this.FilterPeopleByAsync(lastName: lastName).ConfigureAwait(false);
               
        public virtual async Task<TApiModel> GetPersonByEmailAsync(string email) => (await this.FilterPeopleByAsync(email: email).ConfigureAwait(false)).FirstOrDefault();
               
        public virtual async Task<TApiModel> GetPersonByPhoneNumberAsync(string phoneNumber) => (await this.FilterPeopleByAsync(phoneNumber: phoneNumber).ConfigureAwait(false)).FirstOrDefault();

        public virtual async Task<IEnumerable<TApiModel>> FilterPeopleByAsync(string firstName = null, string lastName = null, string email = null, string phoneNumber = null, string address = null) 
        {
            var people = await this.Repository.GetAllAsync().ConfigureAwait(false);

            bool predicate(TDomain person)
            {
                bool firstNameFilter = !string.IsNullOrEmpty(firstName) ? string.Compare(person.FirstName, firstName, StringComparison.OrdinalIgnoreCase) == 0 : true;
                bool lastNameFilter = !string.IsNullOrEmpty(firstName) ? string.Compare(person.LastName, lastName, StringComparison.OrdinalIgnoreCase) == 0 : true;
                bool emailFilter = !string.IsNullOrEmpty(email) ? string.Compare(person.Email, email, StringComparison.OrdinalIgnoreCase) == 0 : true;
                bool phoneNumberFilter = !string.IsNullOrEmpty(phoneNumber) ? string.Compare(person.PhoneNumber, phoneNumber, StringComparison.OrdinalIgnoreCase) == 0 : true;
                bool addressFilter = !string.IsNullOrEmpty(address) ? person.Address.Contains(address, StringComparison.OrdinalIgnoreCase) : true;
                return firstNameFilter && lastNameFilter && emailFilter && phoneNumberFilter && addressFilter;
            }

            var queriedPeople = people.Where(predicate);
            return Mapper.Map<IEnumerable<TApiModel>>(queriedPeople);
        }
    }
}