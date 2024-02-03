using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swappy.Shared.Domain;

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
                    Name = "Samsung S24 Ultra",
                    Description = "Description",
                    Price = 1500,
                    Quantity = 1,
                    ProductDimension = "1x1x1",
                    ProductPicture = "Saumsung Phone.jpg",
                    UserID = 1, 
                    CategoryID = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                ) ; 
        }
    }
}

