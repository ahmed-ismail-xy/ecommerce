namespace ecommerce.Domain.Entities
{
    public class CustomerCart
    {
        public Guid CustomerCartId { get; set; }

        public ICollection<CartItem> CartItems { get; set; }
    }
}
