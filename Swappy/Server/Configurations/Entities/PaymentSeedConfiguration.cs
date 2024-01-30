//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Swappy.Shared.Domain;
//using System;

//namespace Swappy.Server.Configurations.Entities
//{
//    public class PaymentSeedConfiguration : IEntityTypeConfiguration<Payment>
//    {
//        public void Configure(EntityTypeBuilder<Payment> builder)
//        {
//            builder.HasData(
//                new Payment
//                {
//                    Id = 1,
//                    OrderID = 1,
//                    UserID = 1,
//                    TotalPrice = 20.99,
//                    PaymentMethod = "Credit Card",
//                    DateCreated = DateTime.Now,
//                    DateUpdated = DateTime.Now,
//                    CreatedBy = "System",
//                    UpdatedBy = "System"
//                },
//                new Payment
//                {
//                    Id = 2,
//                    OrderID = 2,
//                    UserID = 1,
//                    TotalPrice = 15.99,
//                    PaymentMethod = "PayPal",
//                    DateCreated = DateTime.Now,
//                    DateUpdated = DateTime.Now,
//                    CreatedBy = "System",
//                    UpdatedBy = "System"
//                });
//        }
//    }
//}
