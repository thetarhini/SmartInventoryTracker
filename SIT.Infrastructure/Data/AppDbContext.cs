using Microsoft.EntityFrameworkCore;
using SIT.Core.Entities; // Adjust this if your entities live in a different namespace

namespace SIT.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<InventoryLog> InventoryLogs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    PasswordHash = "zSlgnBJRB13cz59h112V5+oPecDM3KyW9+JuEUnlSOwuXb8BLdx2yOdqG36Yydj31tQF36+dm79l1HMo80Ilfg==", // <-- Replace with real hash
                    PasswordSalt = "9kcV2HHk5cu0N/7/I9UdNkdXgD7cKAtuOTqVMKD00bxtS0phKZH8B83hSvL9WgVrchkTbXTTDjxW3qSVZ2QkoCZ1bALLVXSVAyG6H/KgSECX9IOrJnS8C7nr8JmZm9iAwfBKcMSDKBOSVEqPE3OJWes007nWmun2Z6+c218QeT4=", // <-- Replace with real salt
                    Role = "Admin"
                },
                new User
                {
                    Id = 2,
                    Username = "user",
                    PasswordHash = "Ei0sQQiUfXPg9tT+0na6oVpaOUexR6VRI/tTzEcRn3G2tCVq3rFLBcYTCyAxycgMOBJlquptx2VCkj6vRcv+cQ==", // <-- Replace with real hash
                    PasswordSalt = "oFsHxmNggPoJ9GtEq+CCfD2p2jCsp2fBdSOU7UeoEO+M+xk6okTUgTCMYjrKvC7mqaWqLnIaX4dqWrnd5uTDqY8wpGzmr4AEliLRE8MlnJIxrgnVnWDyq0FJ5UWRgrRe9d1/MleeFF3kQOeAVPpoqs/u+mH//Neva7R3gEJm8Zg=", // <-- Replace with real salt
                    Role = "User"
                }
            );
        }
    }
}
