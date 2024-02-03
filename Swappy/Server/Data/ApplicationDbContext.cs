using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Swappy.Server.Configurations.Entities;
using Swappy.Server.Models;
using Swappy.Shared.Domain;
using System.Reflection.Emit;

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
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }       
        public DbSet<Order> Orders { get; set; }

        //public DbSet<Payment> Payments { get; set; }
        //public DbSet<Message> Messages { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //builder.ApplyConfiguration(new CartSeedConfiguration());
            //builder.ApplyConfiguration(new CartItemsSeedConfiguration());

            //builder.ApplyConfiguration(new MessageSeedConfiguration());
            //builder.ApplyConfiguration(new OrderSeedConfiguration());
            //builder.ApplyConfiguration(new OrderItemsSeedConfiguration());
            //builder.ApplyConfiguration(new PaymentSeedConfiguration());
            

            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new CategorySeedConfiguration());
            builder.ApplyConfiguration(new ProductSeedConfiguration());

            builder.Entity<User>()
                .HasMany(u => u.Products)
                .WithOne(p => p.User)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<User>()
                .HasMany(u => u.CartItems)
                .WithOne(ci => ci.User)
                .OnDelete(DeleteBehavior.Cascade);

            
            builder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Product>()
                .HasMany(p => p.CartItems)
                .WithOne(ci => ci.Product)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CartItem>()
                .HasOne(ci => ci.User)
                .WithMany(u => u.CartItems)
                .HasForeignKey(ci => ci.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasPrecision(18, 2); 






        }

    }
}