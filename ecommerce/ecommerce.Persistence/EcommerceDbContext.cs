using ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Persistence
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Addresses { get; set; }   
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<CustomerCart> customerCarts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<CartItem> CartItems { get; set; } 
    }
}
