CREATE TABLE [dbo].[UserConnection]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [UserId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id),
    [ConnectedUserId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id),
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null DEFAULT (getdate()),
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
