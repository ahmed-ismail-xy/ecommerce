namespace ecommerce.Application.DTOs.Auth
{
    public class Register
    {
        public class Request
        {
            public string Mobile { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
