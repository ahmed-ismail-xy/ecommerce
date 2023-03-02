using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryID { get; set; }
        public string Name { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
