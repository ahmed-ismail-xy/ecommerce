using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.SubCategory
{
    public class GetSubCategory
    {
        public class Request
        {
            public Guid SubCategoryId { get; set; }
        }
        public class Response
        {
            public Guid SubCategoryId { get; set; }
            public string Name { get; set; }
            public string ImgUrl { get; set; }

            public Guid CategoryId { get; set; }
        }
    }
}
