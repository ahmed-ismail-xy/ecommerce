using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.ProductRepo
{
    public class GetProductsBySubCategory
    {
        public class Response
        {
            public Guid ProductId { get; set; }
            public GetProduct Product { get; set; }

            public Guid SubCategoryId { get; set; }

        }
    }
}
