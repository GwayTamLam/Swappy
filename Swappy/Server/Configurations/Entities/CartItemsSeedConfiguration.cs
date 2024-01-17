using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Swappy.Shared.Domain;

namespace Swappy.Server.Configurations.Entities
{
    
    public class CartItemsSeedConfiguration : IEntityTypeConfiguration<CartItems>
    {
        public void Configure(EntityTypeBuilder<CartItems> builder)
        {
            builder.HasData(
                new CartItems
                {
                    Id = 1,
                    ProductId = 1,
                    CartId = 1,
                    ProductQuantity = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new CartItems
                {
                    Id = 2,
                    ProductId = 2,
                    CartId = 1,
                    ProductQuantity = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                });
        }
    }
}

