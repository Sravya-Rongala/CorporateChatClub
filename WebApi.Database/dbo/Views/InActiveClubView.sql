Create View [InActiveClub] As 
Select c.Id,c.Name,c.ClubType,c.Description,c.ClubCreatedBy,c.ClubCreatedOn,s.Reason,s.DeactivatedBy,s.DeactivatedOn
from Club c inner join ClubStatus s on c.Id = s.ClubId
where IsActive = 0 ;

 