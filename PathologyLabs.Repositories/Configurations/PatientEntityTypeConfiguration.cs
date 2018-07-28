using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories.Configurations
{
    public class PatientEntityTypeConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patients");

            builder
                .Property(patient => patient.FirstName)
                .IsRequired();

            builder
                .Property(patient => patient.LastName)
                .IsRequired();

            builder
                .Property(patient => patient.BloodGroup)
                .IsRequired();

            builder
                .HasOne(patient => patient.Parent)
                .WithMany(parent => parent.ChildrenOfParent)
                .HasForeignKey(patient => patient.ParentId);

            builder
                .HasOne(patient => patient.Spouse)
                .WithOne(spouse => spouse.PartnerOfSpouse);
        }
    }
}
