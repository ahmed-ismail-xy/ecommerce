using ecommerce.Application.DTOs;
using ecommerce.Application.Featuers;

namespace ecommerce.Application.Contracts
{
    public interface ICustomerRepository
    {
        public Task<APIResponse<Register.Response>> UpdateCustomerInfo(Register.Request request);
    }
}
