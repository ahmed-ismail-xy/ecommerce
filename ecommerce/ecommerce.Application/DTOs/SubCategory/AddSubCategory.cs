using Microsoft.AspNetCore.Http;

namespace ecommerce.Application.DTOs.SubCategory
{
    public class AddSubCategory
    {
        public class Request
        {
            public string Name { get; set; }
            public IFormFile Img { get; set; }
            public Guid MainCategoryId { get; set; }
        }
    }
}
