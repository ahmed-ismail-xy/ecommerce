using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? ImgUrl { get; set; }

        public Guid? PasswordResetConfirmationId { get; set; }
        public PasswordResetConfirmation PasswordResetConfirmation { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public Guid? CustomerCartId { get; set; }
        public CustomerCart CustomerCart { get; set; }

        public Guid? FavoriteId { get; set; }
        public Favorite Favorite { get; set; }
    }
}
