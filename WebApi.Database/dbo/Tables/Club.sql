CREATE TABLE [dbo].[Club]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [Name] VARCHAR(MAX) NOT NULL, 
    [ClubType] INT NOT NULL, 
    [Description] TEXT NOT NULL, 
    [ProfilePicture] NVARCHAR(MAX) NULL, 
    [ClubCreatedBy] UNIQUEIDENTIFIER NOT NULL, 
    [ClubCreatedOn] DATETIME NOT NULL DEFAULT (getdate()),
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
