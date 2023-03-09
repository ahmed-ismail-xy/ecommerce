using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
