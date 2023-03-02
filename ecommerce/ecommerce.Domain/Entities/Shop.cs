namespace ecommerce.Domain.Entities
{
    public class Shop
    {
        public Guid ShopId { get; set; }
        public string Name { get; set; }
        public string ImgURL { get; set; }
        public string AddressDetails { get; set; }
        public string About { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
