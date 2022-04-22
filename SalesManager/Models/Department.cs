using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesManager.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, ErrorMessage = "Minimum size 100 characters")]
        [Required(ErrorMessage = "Department name required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
