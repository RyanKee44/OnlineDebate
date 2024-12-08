using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineDebate.Domain;

namespace OnlineDebate.Configurations.Entities
{
    public class CommentSeed : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    CommentContent = "I agree!",
                    CommentStance = true,
                    CommentLike = 1000
                },
                new Comment
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    CommentContent = "I Disagree!",
                    CommentStance = false,
                    CommentLike = 100
                }
                );
        }
    }
}
