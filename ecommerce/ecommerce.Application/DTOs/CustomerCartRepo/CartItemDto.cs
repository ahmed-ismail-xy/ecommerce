namespace ecommerce.Application.DTOs.CustomerCartRepo
{
    public class CartItemDto
    {
        public Guid CartItemId { get; set; }
        public int Quantity { get; set; }

        public ProductDto Product { get; set; }
    }
}
