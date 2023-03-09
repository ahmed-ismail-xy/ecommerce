using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.FavoriteRepo
{
    public class FavoriteProductDto
    {
        public Guid FavoriteId { get; set; }
        public ProductDto Product { get; set; }
    }
}
