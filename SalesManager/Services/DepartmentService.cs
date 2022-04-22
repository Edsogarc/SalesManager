using SalesManager.Models;

namespace SalesManager.Services
{
    public class DepartmentService
    {
        private readonly SalesManagerContext _context;
        public DepartmentService(SalesManagerContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
