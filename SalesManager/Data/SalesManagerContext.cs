using Microsoft.EntityFrameworkCore;
using SalesManager.Models;

namespace SalesManager.Data
{
    public class SalesManagerContext : DbContext
    {
        public SalesManagerContext (DbContextOptions<SalesManagerContext> options)
            : base(options)
        {
        }

        public DbSet<SalesManager.Models.Department> Department { get; set; }
    }
}
