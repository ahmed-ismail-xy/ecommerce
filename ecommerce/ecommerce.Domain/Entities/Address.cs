namespace ecommerce.Domain.Entities
{
    public class Address
    {
        public Guid AddresseId { get; set; }
        public string Apartment { get; set; }
        public string AddresseName { get; set; }
        public string Governorate { get; set; }
        public string Area { get; set; }
        public string Block { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string ApartmentNumber { get; set; }
        public string Phone { get; set; }
        public string AddressDetails { get; set; }
    }
}
