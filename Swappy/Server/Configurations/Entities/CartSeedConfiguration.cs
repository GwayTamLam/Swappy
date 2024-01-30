//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Swappy.Shared.Domain;
//using System;

//namespace Swappy.Server.Configurations.Entities
//{
//    public class CartSeedConfiguration : IEntityTypeConfiguration<Cart>
//    {
//        public void Configure(EntityTypeBuilder<Cart> builder)
//        {
//            builder.HasData(
//                new Cart
//                {
//                    Id = 1,
//                    ProductID = 1,
//                    UserID = 1,
//                    ProductQuantity = 2,
//                    TotalPrice = 20.99,
//                    DateCreated = DateTime.Now,
//                    DateUpdated = DateTime.Now,
//                    CreatedBy = "System",
//                    UpdatedBy = "System"
//                },
//                new Cart
//                {
//                    Id = 2,
//                    ProductID = 2,
//                    UserID = 1,
//                    ProductQuantity = 1,
//                    TotalPrice = 15.99,
//                    DateCreated = DateTime.Now,
//                    DateUpdated = DateTime.Now,
//                    CreatedBy = "System",
//                    UpdatedBy = "System"
//                });
//        }
//    }
//}
