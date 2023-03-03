using ecommerce.Application.DTOs.Auth;
using ecommerce.Application.Featuers;
using Microsoft.Win32;

namespace ecommerce.Application.Contracts
{
    public interface IAuthRepository
    {
        public Task<APIResponse> Register(Register.Request request);
        public Task<APIResponse<Login.Response>> Login(Login.Request request);
        public Task<APIResponse> SendEmailForgotPassword(SendEmailForgotPassword.Request request);
        public Task<APIResponse> PasswordConfirmationCode(PasswordConfirmationCode.Request request);
        
    }
}
