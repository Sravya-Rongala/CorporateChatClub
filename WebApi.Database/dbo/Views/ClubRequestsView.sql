Create View ClubRequestsView As
Select cr.ClubId,cr.RequestedBy,u.DisplayName,u.ProfilePicture,u.Email,cr.RequestStatus  from ClubRequest cr
inner join Users u on cr.RequestedBy = u.Id