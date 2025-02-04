using OnlineDebate.Data;

namespace OnlineDebate.Domain
{
    public class Notifications : BaseDomainModel
    {
        public string? NotificationName { get; set; }

        public int UserId { get; set; }
        public int TopicId { get; set; }

        public string? OnlineDebateUserId { get; set; }

        public Topic Topic { get; set; }

        public OnlineDebateUser OnlineDebateUser { get; set; }
    }
}
