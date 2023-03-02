using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class CustomerCart
    {
        [Key]
        public Guid CustomerCartId { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
