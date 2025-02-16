using Microsoft.EntityFrameworkCore;

namespace MicroservicesSolutionProject001.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product.Core.Entities.Product> products { get; set; } 
    }
}


