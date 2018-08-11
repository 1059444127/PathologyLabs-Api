using System.Collections.Generic;
using System.Threading.Tasks;
using PathologyLabs.Domain.Core;
using PathologyLabs.Model.Core;
using PathologyLabs.Model.Core.Patients;

namespace PathologyLabs.Services.Patients
{
    public interface IPatientService : IService<Patient, PatientApiModel, long>
    {
        Task<IEnumerable<ReportApiModel>> GetPatientReportsAsync(long patientId);
    }
}
