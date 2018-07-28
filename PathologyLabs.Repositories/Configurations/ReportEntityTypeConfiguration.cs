using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories.Configurations
{
    public class ReportEntityTypeConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder
                .ToTable("Reports");

            builder
                .HasOne(report => report.Patient)
                .WithMany(patient => patient.Reports)
                .HasForeignKey(report => report.PatientId);

            builder
                .HasOne(report => report.Test)
                .WithMany();
        }
    }
}
