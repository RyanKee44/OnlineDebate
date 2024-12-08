using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineDebate.Domain;

namespace OnlineDebate.Configurations.Entities
{
    public class ArgumentSeed : IEntityTypeConfiguration<Argument>
    {
        public void Configure(EntityTypeBuilder<Argument> builder)
        {
            builder.HasData(
                new Argument
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    ArgumentContent = "I Love PAP",
                    ArgumentStance = true,
                    ArgumentLike = 10000
                },
                new Argument
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    ArgumentContent = "I Hate Dogs",
                    ArgumentStance = false,
                    ArgumentLike = 10
                }
                );
        }
    }
}
