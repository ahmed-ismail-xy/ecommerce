using ecommerce.Application.DTOs.Auth;
using ecommerce.Application.Featuers;

namespace ecommerce.Application.Contracts
{
    public interface IShopRepository
    {
        public Task<APIResponse> GetAllShops(Register.Request request);
        public Task<APIResponse> GetLatestShops(Register.Request request);
    }
}
