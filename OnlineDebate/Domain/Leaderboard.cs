namespace OnlineDebate.Domain
{
    public class Leaderboard : BaseDomainModel
    {
        public int LeaderboardRank { get; set; }
        public int LeaderboardPoints { get; set; }
        public int LeaderboardRefresh { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }
    }
}
