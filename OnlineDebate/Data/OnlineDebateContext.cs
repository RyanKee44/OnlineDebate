using CarRentalManagement.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineDebate.Configurations.Entities;
using OnlineDebate.Data;
using OnlineDebate.Domain;

namespace OnlineDebate.Data
{
    public class OnlineDebateContext(DbContextOptions<OnlineDebateContext> options) : IdentityDbContext<OnlineDebateUser>(options)
    {
        public DbSet<OnlineDebate.Domain.User> User { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Topic> Topic { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Argument> Argument { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Comment> Comment { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Report> Report { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Leaderboard> Leaderboard { get; set; } = default!;

        public DbSet<OnlineDebate.Domain.Notifications> Notifications { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new TopicSeed());
            builder.ApplyConfiguration(new ArgumentSeed());
            builder.ApplyConfiguration(new CommentSeed());
            builder.ApplyConfiguration(new ReportSeed());
            builder.ApplyConfiguration(new NotificationsSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }

    }
}
