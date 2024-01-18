using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Swappy.Shared.Domain;

namespace Swappy.Server.Configurations.Entities
{
    public class MessageSeedConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData(
                new Message
                {
                    Id = 1,
                    MessageContent = "I love R Shwee",
                    UserID = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }

                );
        }
    }
}
