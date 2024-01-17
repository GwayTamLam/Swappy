using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swappy.Shared.Domain;
using System;

namespace Swappy.Server.Configurations.Entities
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Electronics",
                    Description = "Electronic gadgets and devices",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Category
                {
                    Id = 2,
                    Name = "Clothing",
                    Description = "Fashion and apparel",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                });
        }
    }
}
