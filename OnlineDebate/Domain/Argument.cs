namespace OnlineDebate.Domain
{
    public class Argument : BaseDomainModel
    {
        public string? ArgumentContent { get; set; }
        public Boolean ArgumentStance { get; set; }
        public int ArgumentLike { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }

        public Topic Topic { get; set; } // Add this line
    }
}
