using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swappy.Shared.Domain;
using System;

namespace Swappy.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Description for Product 1",
                    Price = 29.99,
                    ProductQuantity = 10,
                    ProductDimension = "10x10x5",
                    ProductPicture = "url-to-product-image-1",
                    UserID = 1,
                    CategoryID = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Description for Product 2",
                    Price = 19.99,
                    ProductQuantity = 15,
                    ProductDimension = "8x8x4",
                    ProductPicture = "url-to-product-image-2",
                    UserID = 2,
                    CategoryID = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                });
        }
    }
}
