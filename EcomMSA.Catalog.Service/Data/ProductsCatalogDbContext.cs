using Catalog.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Service.Data
{
    public class ProductsCatalogDbContext : DbContext
    {
        public ProductsCatalogDbContext(DbContextOptions<ProductsCatalogDbContext> options)
        : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2); // для денежных значений
        }
    }
}
