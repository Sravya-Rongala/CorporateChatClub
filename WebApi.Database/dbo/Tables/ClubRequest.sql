CREATE TABLE [dbo].[ClubRequest]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ClubId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Club(Id),
    [RequestedBy] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id),
    [RequestedOn] DATETIME NOT NULL, 
    [RequestStatus] BIT NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)