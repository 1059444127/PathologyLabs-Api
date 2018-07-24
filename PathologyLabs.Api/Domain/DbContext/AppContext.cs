using Microsoft.EntityFrameworkCore;
using PathologyLabManagementSystemV2.Domain;

namespace PathologyLabManagementSystemV2.Domain
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions opts) : base(opts)
        {

        }        
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {

        }
    }
}