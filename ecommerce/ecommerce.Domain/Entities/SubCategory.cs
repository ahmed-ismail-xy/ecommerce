using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class SubCategory
    {
        [Key]
        public Guid SubCategoryId { get; set; }
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
