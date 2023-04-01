CREATE View [AllUsers] As
SELECT u.Id,u.DisplayName, u.Email, u.Phone, u.About, u.RoleId, u.UserAccess, u.CreatedBy, u.CreatedOn, Count(*) as clubCount 
from Users u inner join UserClubAction ua on u.Id = ua.UserId
GROUP BY u.Id;