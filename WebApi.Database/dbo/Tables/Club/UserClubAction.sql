CREATE TABLE [dbo].[UserClubAction]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [UserId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id), 
    [ClubId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Club(Id), 
    [IsFavourite] BIT NOT NULL DEFAULT 0, 
    [IsMuted] BIT NOT NULL DEFAULT 0, 
    [IsExited] BIT NOT NULL DEFAULT 0, 
    [ExitedOn] DATETIME NULL,
    [ClubOpenedAt] DATETIME NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null DEFAULT (getdate()),
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)