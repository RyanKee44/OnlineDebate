using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineDebate.Domain;

namespace OnlineDebate.Configurations.Entities
{
    public class LeaderboardSeed : IEntityTypeConfiguration<Leaderboard>
    {
        public void Configure(EntityTypeBuilder<Leaderboard> builder)
        {
            builder.HasData(
                new Leaderboard
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    LeaderboardRank = 1,
                    LeaderboardPoints = 1000,
                    LeaderboardRefresh = 3,
                    TopicId = 1,
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },
                new Leaderboard
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    LeaderboardRank = 2,
                    LeaderboardPoints = 1000,
                    LeaderboardRefresh = 3,
                    TopicId = 2,
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                }
                );
        }
    }
}
