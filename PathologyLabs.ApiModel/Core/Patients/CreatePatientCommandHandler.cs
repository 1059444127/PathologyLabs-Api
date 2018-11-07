using System.Threading.Tasks;
using AutoMapper;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Mediation;
using PathologyLabs.Repositories;

namespace PathologyLabs.Model.Core.Patients
{
    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand>
    {
        private readonly IRepository<Patient, long> _patientRepository;

        public CreatePatientCommandHandler(IRepository<Patient, long> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public Task Handle(CreatePatientCommand request)
        {
           Patient patient =  Mapper.Map<Patient>(request);
           return _patientRepository.CreateAsync(patient);
        }
    }
}
