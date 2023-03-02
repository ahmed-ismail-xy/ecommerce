namespace ecommerce.Domain.Entities
{
    public class SubCategory
    {
        public Guid SubCategoryId { get; set; }
        public string Name { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
