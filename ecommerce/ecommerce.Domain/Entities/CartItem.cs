using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class CartItem
    {
        [Key]
        public Guid CartItemId { get; set; }
        public int Quantity { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public Guid CustomerCartId { get; set; }
        public CustomerCart CustomerCart { get; set; }
    }
}
