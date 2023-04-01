Create View [AvailableClubs] As
Select Id,Name,ProfilePicture
from Club inner join ClubStatus on Club.Id = ClubStatus.clubId and ClubId.ClubType != 3
where ClubStatus.IsActive = 1 ;