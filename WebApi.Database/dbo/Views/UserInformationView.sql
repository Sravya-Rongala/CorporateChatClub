Create View [UserInformationView]
as
select u.Id,u.FirstName,u.MiddleName,u.LastName,u.DisplayName,u.Email,u.Phone,u.ProfilePicture,u.Gender,u.About,u.Summary,u.BloodGroup,u.MaritalStatus,u.DateofBirth,CONCAT(a.line1,', ',a.line2,', ',a.City,', ',a.State,', ',a.ZipCode) as Address 
from Users u inner join Address a on u.Id = a.UserId;