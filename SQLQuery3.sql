-- Enable IDENTITY_INSERT
SET IDENTITY_INSERT Leaderboard ON;

INSERT INTO Leaderboard 
(Id, DateCreated, LeaderboardRank, LeaderboardPoints, LeaderboardRefresh, TopicId, OnlineDebateUserId, UserId)
VALUES
(1, GETDATE(), 1, 1000, 3, 1, '3781efa7-66dc-47f0-860f-e506d04102e4', 0),
(2, GETDATE(), 2, 1000, 3, 2, '3781efa7-66dc-47f0-860f-e506d04102e4', 0);

-- Disable IDENTITY_INSERT after operation
SET IDENTITY_INSERT Leaderboard OFF;
