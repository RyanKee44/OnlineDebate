using OnlineDebate.Data;

namespace OnlineDebate.Domain
{
    public class Leaderboard : BaseDomainModel
    {
        public int LeaderboardRank { get; set; }
        public int LeaderboardPoints { get; set; }
        public int LeaderboardRefresh { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }

        public string? OnlineDebateUserId { get; set; }


        public Topic Topic { get; set; }

        public OnlineDebateUser OnlineDebateUser { get; set; }
    }
}
