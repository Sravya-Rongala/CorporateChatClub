Create View [ClubDetailsView] 
As 
Select c.Id,c.ClubType,c.CreatedBy,c.CreatedOn,c.Description,c.Name,c.ProfilePicture,s.IsActive,s.IsReported,s.DeactivatedBy,s.DeactiavtedOn,s.DeletedBy,s.DeletedOn,s.Reason,s.ReactivatedOn,s.ReactivedBy
from Club c inner join
ClubStatus s on c.Id = s.ClubId;