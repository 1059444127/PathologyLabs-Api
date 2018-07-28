using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories.Configurations
{
    public class PathologyTestPatientEntityTypeConfiguration : IEntityTypeConfiguration<PathologyTestPatient>
    {
        public void Configure(EntityTypeBuilder<PathologyTestPatient> builder)
        {
            builder
                .ToTable("PathologyTestPatients")
                .HasKey(x => new { x.PathologyTestId, x.PatientId });
        }
    }
}
