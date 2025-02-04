using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineDebate.Domain;

namespace OnlineDebate.Configurations.Entities
{
    public class ReportSeed : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasData(
                new Report
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    ReportReason = "Hate Speech",
                    ReportType = "Hate",
                    CommentId = 1,
                    ArgumentId = 1,
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },
                new Report
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    ReportReason = "Irrelavent",
                    ReportType = "Not Relavent",
                    CommentId = 2,
                    ArgumentId = 2,
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                }
                );
        }
    }
}
