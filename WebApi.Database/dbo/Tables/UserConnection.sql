CREATE TABLE [dbo].[UserConnection]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [UserId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id),
    [ConnectedUserId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id),
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
