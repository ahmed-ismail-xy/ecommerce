using Microsoft.AspNetCore.Http;

namespace ecommerce.Application.DTOs.CategoryRepo
{
    public class AddCategory
    {
        public class Request
        {
            public string Name { get; set; }
            public IFormFile Img { get; set; }
        }
    }
}
