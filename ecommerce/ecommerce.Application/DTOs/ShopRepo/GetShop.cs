using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.ShopRepo
{
    public class GetShop
    {
        public class Request
        {
            public Guid ShopId { get; set; }
        }
        public class Response
        {
            public Guid ShopId { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string ImgURL { get; set; }
            public string AddressDetails { get; set; }
            public string About { get; set; }

            public ICollection<ProductDto> Products { get; set; }
        }
    }
}
