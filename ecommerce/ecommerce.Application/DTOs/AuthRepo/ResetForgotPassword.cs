namespace ecommerce.Application.DTOs.Auth
{
    public class ResetForgotPassword
    {
        public class Request
        {
            public string Password { get; set; }
            public string Email { get; set; }
        }
    }
}
