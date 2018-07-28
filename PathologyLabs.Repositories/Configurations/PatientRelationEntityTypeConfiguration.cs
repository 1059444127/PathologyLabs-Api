using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories.Configurations
{
    public class PatientRelationEntityTypeConfiguration : IEntityTypeConfiguration<PatientRelation>
    {
        public void Configure(EntityTypeBuilder<PatientRelation> builder)
        {
            builder.ToTable("PatientRelations");
        }
    }
}
