USE [CourseProjectCS2];
GO

CREATE PROCEDURE getChats @username nvarchar(16)
AS
SELECT * FROM Chats
WHERE Chats.id = (SELECT chatid FROM UserChat
					WHERE userid = (SELECT id FROM Users 
									WHERE username = @username));
GO

CREATE PROCEDURE getMessages @chat int
AS
SELECT * FROM Messages
WHERE chat = @chat
GO

--EXEC getChats @username = 'user'