using ecommerce.Application.Featuers;

namespace ecommerce.Application.DTOs.CustomerRepo
{
    public class UpdateCustomerInfo
    {
        public class Request
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? Mobile { get; set; }
            public string? Email { get; set; }
        }
        public class Response
        {
            public List<APIResponse> APIResponses = new List<APIResponse>();
        }
    }
}
