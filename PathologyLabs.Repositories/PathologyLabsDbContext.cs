using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PathologyLabs.Domain.App;
using PathologyLabs.Domain.Core;

namespace PathologyLabs.Repositories
{
    public class PathologyLabsDbContext : IdentityDbContext<PathologyLabsUser, IdentityRole<long>, long>
    {
        public PathologyLabsDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Patient> Patients { get; set; }

        public virtual DbSet<PatientRelation> PatientRelations { get; set; }

        public virtual DbSet<PathologyTest> PathologyTests { get; set; }

        public virtual DbSet<Report> Reports { get; set; }
    }
}
