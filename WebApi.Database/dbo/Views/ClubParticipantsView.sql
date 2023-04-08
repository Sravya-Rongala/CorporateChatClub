Create View 

ClubParticipantsView as 

Select u.Id,u.Email,u.DisplayName,u.ProfilePicture,c.ClubId,c.IsBlocked,c.IsActive,c.Role

from Users u inner join ClubMember c on u.Id = c.UserId;






