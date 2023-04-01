CREATE TABLE [dbo].[ClubMember]
(
	[ClubId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Club(Id), 
    [UserId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id),
    [AddedBy] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id), 
    [AddedOn] DATETIME NOT NULL  , 
    [RemovedBy] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id), 
    [RemovedOn] DATETIME NULL , 
    [IsBlocked] BIT NULL, 
    [BlockedBy] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id), 
    [Role] INT NOT NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1, 
    [DeactivatedBy] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id), 
    [DeactivatedOn] DATETIME NULL, 
    [ReactivatedBy] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id), 
    [ReactivatedOn] DATETIME NULL,
    [Reason] TEXT NULL, 
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
