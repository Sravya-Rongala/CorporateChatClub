

Create view [ClubDescriptionView] 

as SELECT c.Id, c.Name, c.ClubType,c.Description,c.ProfilePicture, (SELECT DisplayName FROM [Users] WHERE Id = c.ClubCreatedBy) AS ClubCreatedBy, c.ClubCreatedOn, 

    (SELECT COUNT(*) FROM ClubMember WHERE ClubId = c.Id) AS MemberCount

FROM Club c


