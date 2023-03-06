using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.SubCategory
{
    public class GetSubCategoryWithProducts
    {
        public Guid SubCategoryId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }

        public Guid CategoryId { get; set; }

        public ICollection<ProductSubCategory> ProductSubCategories { get; set; }
    }
}
