using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swappy.Shared.Domain;
using System;

namespace Swappy.Server.Configurations.Entities
{
    public class OrderItemsSeedConfiguration : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> builder)
        {
            builder.HasData(
                new OrderItems
                {
                    Id = 1,
                    ProductId = 1,
                    ProductQuantity = 2,
                    CartId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new OrderItems
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
