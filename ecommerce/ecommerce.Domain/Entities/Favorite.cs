namespace ecommerce.Domain.Entities
{
    public class Favorite
    {
        public Guid FavoriteId { get; set; }

        public ICollection<Product> Products { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
