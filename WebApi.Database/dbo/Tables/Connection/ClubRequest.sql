CREATE TABLE [dbo].[ClubRequest]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [ClubId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Club(Id),
    [RequestedBy] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id),
    [RequestedOn] DATETIME NOT NULL DEFAULT (getdate()), 
    [RequestStatus] INT NULL DEFAULT 1,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null DEFAULT (getdate()),
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)