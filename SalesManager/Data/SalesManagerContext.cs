using Microsoft.EntityFrameworkCore;

namespace SalesManager.Models
{
    public class SalesManagerContext : DbContext
    {
        public SalesManagerContext (DbContextOptions<SalesManagerContext> options)
            : base(options)
        {
        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
