using Microsoft.AspNetCore.Http;

namespace ecommerce.Application.DTOs.CustomerRepo
{
    public class UpdateCustomerImg
    {
        public class Request
        {
            public IFormFile Img { get; set; }
        }
        public class Response
        {

        }
    }
}
