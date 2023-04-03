CREATE TABLE [dbo].[UserPrivelege]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [RoleId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES UserRole(Id), 
    [UserId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id), 
    [Privelege] VARCHAR(MAX) NOT NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null DEFAULT (getdate()),
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
