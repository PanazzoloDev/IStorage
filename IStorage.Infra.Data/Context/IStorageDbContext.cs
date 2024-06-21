using IStorage.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IStorage.Infra.Data.Context
{
    public class IStorageDbContext : DbContext
    {
        public IStorageDbContext(DbContextOptions<IStorageDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialProduct> MaterialProducts { get; set; }
        public DbSet<Movement> Movements { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}