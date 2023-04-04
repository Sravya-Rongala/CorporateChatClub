Create View [AvailableClubsView]
As
Select Club.Id,Name,ProfilePicture
from Club inner join ClubStatus on Club.Id = ClubStatus.clubId and Club.ClubType != 3
where ClubStatus.IsActive = 1 ;