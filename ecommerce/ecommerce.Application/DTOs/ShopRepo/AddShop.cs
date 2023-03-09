using Microsoft.AspNetCore.Http;

namespace ecommerce.Application.DTOs.ShopRepo
{
    public class AddShop
    {
        public class Request
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public IFormFile ImgURL { get; set; }
            public string AddressDetails { get; set; }
            public string About { get; set; }
        }
    }
}
