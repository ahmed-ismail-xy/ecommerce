using ecommerce.Domain.Entities;

namespace ecommerce.Application.DTOs.ProductRepo
{
    public class GetProduct
    {
        public class Request
        {
            public Guid ProductId { get; set; }
        }
        public class Response
        {
            public Guid ProductId { get; set; }
            public string Name { get; set; }
            public string Details { get; set; }
            public Decimal Price { get; set; }
            public Shop Shop { get; set; }
            public ICollection<ProductImgDto> ProductImgs { get; set; }
        }
    }
}
