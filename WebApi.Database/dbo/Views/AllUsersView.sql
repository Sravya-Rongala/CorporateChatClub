Create View [AllUsersView]
As
Select u.Id,u.DisplayName, u.Email, u.Phone, u.About, u.UserAccess,u.BloodGroup,u.DateOfBirth,u.Gender,u.MaritalStatus,u.Summary,u.ProfilePicture,u.AddedBy,u.AddenOn,ua.ClubId,ua.IsActive
from Users u inner join ClubMember ua on u.Id = ua.UserId;