CREATE TABLE [dbo].[UserChat]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [UserConnectionId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES UserConnection(Id),
    [IsFavourite] BIT NOT NULL, 
    [IsMuted] BIT NOT NULL, 
    [IsBlocked] BIT NOT NULL, 
    [BlockedOn] DATETIME NULL, 
    [MessageId] UNIQUEIDENTIFIER NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
