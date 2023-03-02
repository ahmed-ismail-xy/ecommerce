namespace ecommerce.Domain.Entities
{
    public class Category
    {
        public Guid CategoryID { get; set; }
        public string Name { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
