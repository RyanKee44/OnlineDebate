using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineDebate.Domain;

namespace OnlineDebate.Configurations.Entities
{
    public class TopicSeed : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasData(
                new Topic
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    TopicName = "Is the PAP Good?",
                    TopicCategory = "Politics",
                    TopicDescription = "I think the PAP is good overall but interested" +
                    "in other opinions ^w^",
                    TopicRules = "No Hate and 10 Mins for each Side!",
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"

                },
                new Topic
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    TopicName = "Cats or Dogs",
                    TopicCategory = "Fun",
                    TopicDescription = "Are Cats or Dogs Better?",
                    TopicRules = "No Hate and 10 Mins for each Side!",
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                }
                );
        }
    }
}
