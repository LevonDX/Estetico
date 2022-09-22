global using Estetico.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Estetico.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Estate>()
                .Property(x => x.Deleted)
                .HasDefaultValue(false);

            builder.Entity<City>()
               .Property(x => x.Deleted)
               .HasDefaultValue(false);

            builder.Entity<Country>()
               .Property(x => x.Deleted)
               .HasDefaultValue(false);

            builder.Entity<Address>()
               .Property(x => x.Deleted)
               .HasDefaultValue(false);

            base.OnModelCreating(builder);
        }
        
        public DbSet<Estate> Estates { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
    }
}