namespace ecommerce.Application.DTOs.Auth
{
    public class PasswordConfirmationCode
    {
        public class Request
        {
            public string Email { get; set; }
            public string Code { get; set; }
        }
    }
}
