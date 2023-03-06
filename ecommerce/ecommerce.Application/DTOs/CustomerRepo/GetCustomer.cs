namespace ecommerce.Application.DTOs.CustomerRepo
{
    public class GetCustomer
    {
        public class Response
        {
            public Guid CustomerId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Mobile { get; set; }
            public string Email { get; set; }
            public string ImgUrl { get; set; }
        }
    }
}
