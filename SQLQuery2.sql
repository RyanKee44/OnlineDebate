SELECT * 
FROM Argument


UPDATE Argument
SET OnlineDebateUserId = NULL
WHERE OnlineDebateUserId NOT IN (SELECT Id FROM AspNetUsers);

ALTER TABLE Argument
ALTER COLUMN OnlineDebateUserId nvarchar(450) NULL;

UPDATE Argument
SET OnlineDebateUserId = '3781efa7-66dc-47f0-860f-e506d04102e4'