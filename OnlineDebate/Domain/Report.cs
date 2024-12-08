namespace OnlineDebate.Domain
{
    public class Report : BaseDomainModel
    {
        public string? ReportReason { get; set; }
        public string? ReportType { get; set; }
        public int UserId { get; set; }
        public int ArgumentId { get; set; }
        public int CommentId { get; set; }
    }
}
