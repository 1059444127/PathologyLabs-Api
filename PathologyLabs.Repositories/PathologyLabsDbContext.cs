using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PathologyLabs.Domain.App;
using PathologyLabs.Domain.Core;
using PathologyLabs.Repositories.Configurations;

namespace PathologyLabs.Repositories
{
    public class PathologyLabsDbContext : IdentityDbContext<PathologyLabsUser, IdentityRole<long>, long>
    {
        public virtual DbSet<Patient> Patients { get; set; }

        public virtual DbSet<PatientRelation> PatientRelations { get; set; }

        public virtual DbSet<PathologyTest> PathologyTests { get; set; }

        public virtual DbSet<Report> Reports { get; set; }

        public PathologyLabsDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PathologyTestEntityTypeConfiguration());
            builder.ApplyConfiguration(new PathologyTestPatientEntityTypeConfiguration());
            builder.ApplyConfiguration(new PatientEntityTypeConfiguration());
            builder.ApplyConfiguration(new PatientRelationEntityTypeConfiguration());
            builder.ApplyConfiguration(new ReportEntityTypeConfiguration());
            builder.ApplyConfiguration(new TestTypeEntityTypeConfiguration());
        }
    }
}
