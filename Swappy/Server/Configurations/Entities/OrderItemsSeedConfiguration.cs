using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swappy.Shared.Domain;
using System;

namespace Swappy.Server.Configurations.Entities
{
    public class OrderItemsSeedConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
                new OrderItem
                {
                    Id = 1,
                    ProductId = 1,
                    ProductQuantity = 1,
                    CartId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new OrderItem
                {
                    Id = 2,
                    ProductId = 2,
                    ProductQuantity = 1,
                    CartId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                });
        }
    }
}
