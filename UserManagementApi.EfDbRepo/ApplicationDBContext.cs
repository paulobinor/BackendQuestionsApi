using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagementApi.Core.Models;

namespace UserManagementApi.EfDbRepo
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            SeedCustomerData(builder);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { ConcurrencyStamp = "1", Name = "Admin", NormalizedName = "Admin" },
                new IdentityRole { ConcurrencyStamp = "2", Name = "User", NormalizedName = "User" },
                new IdentityRole { ConcurrencyStamp = "3", Name = "HR", NormalizedName = "HR" }
                );
        }

        private void SeedCustomerData(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasData(
                new Customer { CustomerNo = "C001", Name = "John Doe", Id = -1},
                new Customer { CustomerNo = "C002", Name = "Jane Doe", Id = -2 },
                new Customer { CustomerNo = "C003", Name = "Akin Mustapha Njoku", Id = -3 }
                );
        }
    }
}
