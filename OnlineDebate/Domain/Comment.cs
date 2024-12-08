namespace OnlineDebate.Domain
{
    public class Comment : BaseDomainModel
    {
        public string? CommentContent { get; set; }
        public Boolean CommentStance { get; set; }
        public int CommentLike { get; set; }
        public int UserId { get; set; }
        public int ArgumentId { get; set; }
    }
}
