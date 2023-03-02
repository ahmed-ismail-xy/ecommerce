using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class Favorite
    {
        [Key]
        public Guid FavoriteId { get; set; }

        public ICollection<Product> Products { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
