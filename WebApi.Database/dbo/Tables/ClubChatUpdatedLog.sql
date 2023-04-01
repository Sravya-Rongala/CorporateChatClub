CREATE TABLE [dbo].[ClubChatUpdatedLog]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ClubId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Club(Id), 
    [UpdatedOn] DATETIME NOT NULL, 
    [UpdatedBy] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id), 
    [MessageId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Message(Id),
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)