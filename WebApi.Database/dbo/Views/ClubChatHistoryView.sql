Create View ClubChatHistoryView 
As 
Select u.ClubId, m.Attachment , m.Body ,m.SenderId,m.SentTime, a.DisplayName , a.ProfilePicture
from Message m inner join UserClubAction u on u.UserId = m.SenderId and
u.ClubId = m.ClubId inner join Users a on m.SenderId = a.Id