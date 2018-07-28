using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories.Configurations
{
    public class PathologyTestEntityTypeConfiguration : IEntityTypeConfiguration<PathologyTest>
    {
        public void Configure(EntityTypeBuilder<PathologyTest> builder)
        {
            builder.ToTable("PathologyTests");

            builder
                .Property(test => test.Name)
                .IsRequired();

            builder
                .HasOne(test => test.Type)
                .WithMany(type => type.Tests)
                .HasForeignKey(test => test.TestTypeId);
        }
    }
}
