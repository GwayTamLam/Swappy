using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swappy.Server.Configurations.Entities;
using Swappy.Server.Models;
using Swappy.Shared.Domain;

namespace Swappy.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfiguration(new CartSeedConfiguration());
            //builder.ApplyConfiguration(new CartItemsSeedConfiguration());
            builder.ApplyConfiguration(new CategorySeedConfiguration());
            //builder.ApplyConfiguration(new MessageSeedConfiguration());
            //builder.ApplyConfiguration(new OrderSeedConfiguration());
            //builder.ApplyConfiguration(new OrderItemsSeedConfiguration());
            //builder.ApplyConfiguration(new PaymentSeedConfiguration());
            //builder.ApplyConfiguration(new ProductSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());


            // Configure the relationship between Cart and User
            builder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserID)
                .OnDelete(DeleteBehavior.Restrict); // or use DeleteBehavior.NoAction

            // Configure the relationship between Cart and Product
            builder.Entity<Cart>()
                .HasOne(c => c.Product)
                .WithMany()
                .HasForeignKey(c => c.ProductID)
                .OnDelete(DeleteBehavior.Restrict); // or use DeleteBehavior.NoAction

            builder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.NoAction); // or use DeleteBehavior.SetNull if applicable

        }

    }
}