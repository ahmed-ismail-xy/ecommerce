namespace ecommerce.Domain.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public Decimal Price { get; set; }
        public string ImgURL { get; set; }
    }
}
