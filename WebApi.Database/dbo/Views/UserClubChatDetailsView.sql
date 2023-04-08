Create View UserClubChatDetailsView AS
Select c.Id as ChatId,Name as ChatName,IsFavourite as IsFavouriteChat , IsMuted as IsChatMuted,uc.UserId
from Club c inner join UserClubAction uc on c.Id = uc.ClubId 