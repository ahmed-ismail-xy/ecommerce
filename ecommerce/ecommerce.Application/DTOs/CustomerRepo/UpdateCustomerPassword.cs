namespace ecommerce.Application.DTOs.CustomerRepo
{
    public class UpdateCustomerPassword
    {
        public class Request
        {
            public string OldPasswoed { get; set; }
            public string NewPasswoed { get; set; }
        }
    }
}
