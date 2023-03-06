namespace ecommerce.Application.DTOs.Auth
{
    public class Login
    {
        public class Request
        {
            public string EmailOrMobile { get; set; }
            public string Password { get; set; }
        }
        public class Response
        {
            public Guid CustomerId { get; set; }
            public string Token { get; set; }
            public DateTime ExpireDate { get; set; }
        }
    }
}
