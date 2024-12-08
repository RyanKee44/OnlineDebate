using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineDebate.Configurations.Entities;
using OnlineDebate.Domain;

namespace OnlineDebate.Data
{
    public class OnlineDebateContext : DbContext
    {
        public OnlineDebateContext (DbContextOptions<OnlineDebateContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineDebate.Domain.User> User { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Topic> Topic { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Argument> Argument { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Comment> Comment { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Report> Report { get; set; } = default!;
        public DbSet<OnlineDebate.Domain.Leaderboard> Leaderboard { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new TopicSeed());
            builder.ApplyConfiguration(new ArgumentSeed());
            builder.ApplyConfiguration(new CommentSeed());
            builder.ApplyConfiguration(new ReportSeed());
        }
    }
}
