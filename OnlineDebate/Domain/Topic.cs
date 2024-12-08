﻿namespace OnlineDebate.Domain
{
    public class Topic : BaseDomainModel
    {
        public string? TopicName { get; set; }
        public string? TopicCategory { get; set; }
        public string? TopicDescription { get; set; }
        public string? TopicRules { get; set; }
        public int UserId { get; set; }
    }
}
