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
                },
                new Report
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    ReportReason = "Irrelavent",
                    ReportType = "Not Relavent",
                }
                );
        }
    }
}
