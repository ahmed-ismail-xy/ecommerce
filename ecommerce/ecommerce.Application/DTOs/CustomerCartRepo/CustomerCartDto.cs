using ecommerce.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace ecommerce.Application.DTOs.CustomerCartRepo
{
    public class CustomerCartDto
    {
        public Guid CustomerCartId { get; set; }
        public Guid CustomerId { get; set; }
        public ICollection<CartItemDto> CartItems { get; set; }
    }
}
