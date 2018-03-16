using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OkOceanFisheries.Model.Entities
{
    public class OOFContext : DbContext
    {
        public OOFContext() : base("OOF")
        { }

        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}