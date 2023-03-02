using ecommerce.Application.DTOs;
using ecommerce.Application.Featuers;
using Microsoft.Win32;

namespace ecommerce.Application.Contracts
{
    public interface IAuthRepository
    {
        public Task<APIResponse<Register.Response>> RegisterCustomerAsync(Register.Request request);
        public Task<APIResponse<Login.Response>> LoginCustomerAsync(Login.Request request);
        public Task<APIResponse<Login.Response>> ForgotPasswordAsync(Login.Request request);
        
    }
}
