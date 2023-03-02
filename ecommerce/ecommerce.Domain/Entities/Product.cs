using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public Decimal Price { get; set; }
        public string ImgURL { get; set; }


        public Guid FavoriteId { get; set; }
        public Favorite Favorite { get; set; }

        public Guid ShopId { get; set; }
        public Shop Shop { get; set; }
    }
}
