using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.ShopRepo
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public Decimal Price { get; set; }
        public DateTime CreateAt { get; set; }

        public ICollection<ProductImgDto> ProductImgs { get; set; }
    }
}
