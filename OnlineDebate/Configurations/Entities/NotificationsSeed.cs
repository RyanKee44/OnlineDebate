﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineDebate.Domain;

namespace OnlineDebate.Configurations.Entities
{
    public class NotificationsSeed : IEntityTypeConfiguration<Notifications>
    {
        public void Configure(EntityTypeBuilder<Notifications> builder)
        {
            builder.HasData(
                new Notifications
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    NotificationName = "Hey Brother, Here's a topic you might be interested in",
                    TopicId = 1,
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },
                new Notifications
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    NotificationName = "Oh hi",
                    TopicId = 1,
                    OnlineDebateUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                }
                );
        }
    }
}
