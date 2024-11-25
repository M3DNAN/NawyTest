using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryModel.Models;

namespace DataBaseModel
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Developer> Developers { get; set; }

        public DbSet<CompanyInstallment> CompanyInstallments { get; set; }

        public DbSet<CompanyTransaction> CompanyTransactions { get; set; }

        public DbSet<SharesTransaction> SharesTransactions { get; set; }
        public DbSet<Installment> Installments { get; set; }
        public DbSet<Unit> Units { get; set; }

        public DbSet<UnitDescription> UnitDescriptions { get; set; }

        public DbSet<UnitImages> UnitImages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

      //      modelBuilder.Entity<CompanyTransaction>()
      //.HasOne(ct => ct.Unit)
      //.WithMany()
      //.HasForeignKey(ct => ct.UnitId)
      //.OnDelete(DeleteBehavior.Restrict); // Use Restrict instead of Cascade

      //      modelBuilder.Entity<CompanyTransaction>()
      //          .HasOne(ct => ct.Developer)
      //          .WithMany()
      //          .HasForeignKey(ct => ct.DeveloperId)
      //          .OnDelete(DeleteBehavior.Restrict); // Use Restrict instead of Cascade

        }
    }
}
