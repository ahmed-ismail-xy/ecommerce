using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.FavoriteRepo
{
    public class GetFavorite
    {
        public Guid FavoriteId { get; set; }
        public ICollection<FavoriteProductDto> FavoriteProducts { get; set; }
        public Guid CustomerId { get; set; }
    }
}
