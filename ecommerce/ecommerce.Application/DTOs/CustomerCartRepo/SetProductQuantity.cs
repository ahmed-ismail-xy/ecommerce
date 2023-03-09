namespace ecommerce.Application.DTOs.CustomerCartRepo
{
    public class SetProductQuantity
    {
        public class Request
        {
            public Guid CartItemId { get; set; }
            public int Quantity { get; set; }
        }
    }
}
