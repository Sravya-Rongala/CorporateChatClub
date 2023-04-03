CREATE TABLE [dbo].[UserChat]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [UserConnectionId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES UserConnection(Id),
    [IsFavourite] BIT NOT NULL DEFAULT 0, 
    [IsMuted] BIT NOT NULL DEFAULT 0, 
    [IsBlocked] BIT NOT NULL DEFAULT 0, 
    [BlockedOn] DATETIME NULL, 
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null DEFAULT (getdate()),
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
