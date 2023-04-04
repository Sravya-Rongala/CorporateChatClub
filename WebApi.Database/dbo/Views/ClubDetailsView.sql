Create View [ClubDetailsView] 
As 
Select c.Id as ClubId,c.ClubType,c.ClubCreatedBy,c.ClubCreatedOn,c.Description as ClubDescription,c.Name as ClubName,c.ProfilePicture as ClubProfilePicture,s.IsActive,s.IsReported,s.DeactivatedBy,s.DeactiavtedOn,s.DeletedBy,s.DeletedOn,s.Reason,s.ReactivatedOn,s.ReactivedBy
from Club c inner join
ClubStatus s on c.Id = s.ClubId;