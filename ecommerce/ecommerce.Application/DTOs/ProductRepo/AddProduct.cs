using ecommerce.Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace ecommerce.Application.DTOs.ProductRepo
{
    public class AddProduct
    {
        public class Request
        {
            public string Name { get; set; }
            public string Details { get; set; }
            public Decimal Price { get; set; }
            public Guid ShopId { get; set; }
            public ICollection<IFormFile> ProductImgs { get; set; }
        }
      
    }
}
