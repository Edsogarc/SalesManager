using SalesManager.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesManager.Services
{
    public class DepartmentService
    {
        private readonly SalesManagerContext _context;
        public DepartmentService(SalesManagerContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
