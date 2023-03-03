using ecommerce.Application.DTOs.Auth;
using ecommerce.Application.Featuers;

namespace ecommerce.Application.Contracts
{
    public interface IProductRepository
    {
        public Task<APIResponse> GetAllProducts(Register.Request request);
        public Task<APIResponse> GetLatestProducts(Register.Request request);
        public Task<APIResponse> GetProductById(Register.Request request);
        public Task<APIResponse> GetRelatedProducts(Register.Request request);

    }
}
