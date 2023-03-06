using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.CategoryRepo
{
    public class GetCategoryWithSubCategory
    {
        public class Request
        {
            public Guid CategoryId { get; set; }
        }
        public class Response
        {
            public Guid CategoryId { get; set; }
            public string Name { get; set; }
            public string ImgUrl { get; set; }
            public ICollection<SubCategoryDto> SubCategories { get; set; }
        }
    }
}
