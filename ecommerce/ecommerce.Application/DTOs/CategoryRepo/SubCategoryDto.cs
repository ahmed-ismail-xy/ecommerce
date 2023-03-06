namespace ecommerce.Application.DTOs.CategoryRepo
{
    public class SubCategoryDto
    {
        public Guid SubCategoryId { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public Guid CategoryId { get; set; }
    }
}
