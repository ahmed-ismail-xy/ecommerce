using ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ecommerce.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=aspnet-ecommerce;Trusted_Connection=True");
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasOne<CustomerCart>(c => c.CustomerCart)
                .WithOne(cc => cc.Customer)
                .HasForeignKey<CustomerCart>(cc => cc.CustomerId);

            modelBuilder.Entity<Customer>()
                .HasOne<Favorite>(c => c.Favorite)
                .WithOne(f => f.Customer)
                .HasForeignKey<Favorite>(f => f.CustomerId);

            modelBuilder.Entity<Address>()
                .HasOne<Customer>(a => a.Customer)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CustomerId);

            modelBuilder.Entity<CartItem>()
                .HasOne<CustomerCart>(c => c.CustomerCart)
                .WithMany(cc => cc.CartItems)
                .HasForeignKey(c => c.CustomerCartId);

            modelBuilder.Entity<Product>()
                .HasOne<Favorite>(p => p.Favorite)
                .WithMany(f => f.Products)
                .HasForeignKey(p => p.FavoriteId);

            modelBuilder.Entity<Product>()
                .HasOne<Shop>(p => p.Shop)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.ShopId);

            modelBuilder.Entity<SubCategory>()
                .HasOne<Category>(sc => sc.Category)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(sc => sc.CategoryId);
            
        }

    }
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("your connection string");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
