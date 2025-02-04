using OnlineDebate.Data;

namespace OnlineDebate.Domain
{
    public class Comment : BaseDomainModel
    {
        public string? CommentContent { get; set; }
        public Boolean CommentStance { get; set; }
        public int CommentLike { get; set; }
        public int UserId { get; set; }
        public int ArgumentId { get; set; }

        public string? OnlineDebateUserId { get; set; }

        public Argument Argument  { get; set; }

        public OnlineDebateUser OnlineDebateUser { get; set; }
    }
}
