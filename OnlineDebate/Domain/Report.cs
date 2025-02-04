using OnlineDebate.Data;

namespace OnlineDebate.Domain
{
    public class Report : BaseDomainModel
    {
        public string? ReportReason { get; set; }
        public string? ReportType { get; set; }
        public int UserId { get; set; }
        public int ArgumentId { get; set; }
        public int CommentId { get; set; }
        public string? OnlineDebateUserId { get; set; }

        public Comment Comment { get; set; }

        public Argument Argument { get; set; }

        public OnlineDebateUser OnlineDebateUser { get; set; }
    }
}
