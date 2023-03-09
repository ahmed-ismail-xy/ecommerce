namespace ecommerce.Application.DTOs.SubCategory
{
    public class GetSubCategoriesByShopId
    {
        public class Request
        {
            public Guid ShopId { get; set; }
        }
        public class Response
        {
            public GetSubCategory.Response SubCategory { get; set; }

        }
    }
}
