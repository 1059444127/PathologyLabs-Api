using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Core;
using PathologyLabs.Model.Core.Patients;
using PathologyLabs.Repositories;

namespace PathologyLabs.Services.Patients
{
    public class PatientService : Service<Patient, PatientApiModel, long>, IPatientService
    {
        protected PatientService(IRepository<Patient, long> repository) : base(repository)
        {
        }

        public async Task<IEnumerable<ReportApiModel>> GetPatientReportsAsync(long patientId)
        {
            IQueryable<Patient> patients = await this.Repository.GetAllIncludingAsync(patient => patient.Reports).ConfigureAwait(false);
            IEnumerable<Report> reports = patients?.Single(patient => patient.Id == patientId).Reports;
            return Mapper.Map<IEnumerable<ReportApiModel>>(reports);
        }
    }
}
