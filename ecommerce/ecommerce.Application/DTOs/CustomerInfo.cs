namespace ecommerce.Application.DTOs
{
    public class CustomerInfo
    {
        public class Request
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Mobile { get; set; }
            public string Email { get; set; }
        }
    }
}
