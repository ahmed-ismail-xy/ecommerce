namespace ecommerce.Domain.Entities
{
    public class FavoriteProduct
    {
        public Guid FavoriteId { get; set; }
        public Favorite Favorite { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
