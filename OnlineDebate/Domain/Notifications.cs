namespace OnlineDebate.Domain
{
    public class Notifications : BaseDomainModel
    {
        public string? NotificationName { get; set; }

        public int UserId { get; set; }
        public int TopicId { get; set; }
    }
}
