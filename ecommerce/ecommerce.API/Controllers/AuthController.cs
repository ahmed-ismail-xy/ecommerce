using ecommerce.Application.Contracts;
using ecommerce.Application.DTOs.Auth;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterCustomer([FromForm] Register.Request request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _authRepository.Register(request);
            return result.Success ? (IActionResult)Ok(result) : BadRequest(result.Message);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginCustomer([FromForm] Login.Request request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _authRepository.Login(request);

            return result.Success ? (IActionResult)Ok(result.Data) : BadRequest(result.Message);
        }

        [HttpPost("SendEmailForgotPassword")]
        public async Task<IActionResult> SendEmailForgotPassword([FromForm] SendEmailForgotPassword.Request request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _authRepository.SendEmailForgotPassword(request);

            return result.Success ? (IActionResult)Ok(result) : BadRequest(result.Message);
        }

        [HttpPost("PasswordConfirmationCode")]
        public async Task<IActionResult> PasswordConfirmationCode([FromForm] PasswordConfirmationCode.Request request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _authRepository.PasswordConfirmationCode(request);

            return result.Success ? (IActionResult)Ok(result) : BadRequest(result.Message);
        }
    }
}