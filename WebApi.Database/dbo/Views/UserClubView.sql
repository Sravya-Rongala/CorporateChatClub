
Create View [UserClubView]

as 

SELECT c.Id as ClubId, 

c.[name], 

c.ProfilePicture, 

u.Id as UserId,

(SELECT TOP 1 Body FROM Message WHERE SenderId =c.Id ORDER BY SentTime DESC) AS LastMessage,

(SELECT TOP 1 Attachment FROM Message WHERE ClubId = c.Id ORDER BY SentTime DESC) AS LastAttachment,

(SELECT count(*) FROM Message WHERE ClubId = c.Id AND SentTime > cm.ClubOpenedAt) AS UnReadCount, 

(SELECT TOP 1 SentTime FROM Message WHERE ClubId=c.Id ORDER BY SentTime DESC) AS PostedOn,

(SELECT DisplayName FROM Users WHERE Id = (SELECT TOP 1 SenderId FROM Message WHERE ClubId=c.Id ORDER BY SentTime DESC)) AS LastMessageDisplayName,

cm.IsFavourite,

cm.ClubOpenedAt

FROM Club c 

INNER JOIN UserClubAction cm ON c.Id=cm.ClubId 

INNER JOIN Users u ON u.Id=cm.UserId





