using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineDebate.Data;
using OnlineDebate.Domain;

namespace OnlineDebate.Configurations.Entities
{
    public class ArgumentSeed : IEntityTypeConfiguration<Argument>
    {
        public void Configure(EntityTypeBuilder<Argument> builder)
        {
            builder.HasData(
                new Argument
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    ArgumentContent = "I Love PAP",
                    ArgumentStance = true,
                    ArgumentLike = 10000,
                    TopicId = 1, 
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },
                new Argument
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    ArgumentContent = "I Hate Dogs",
                    ArgumentStance = false,
                    ArgumentLike = 10,
                    TopicId = 2, 
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                }
                );
        }
    }
}
