using SalesManager.Models;

namespace SalesManager.Services
{
    public class SellerService
    {
        private readonly SalesManagerContext _context;

        public SellerService(SalesManagerContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
