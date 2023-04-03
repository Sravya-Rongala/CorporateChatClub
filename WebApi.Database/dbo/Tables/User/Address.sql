CREATE TABLE [dbo].[Address]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [UserId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id),
    [Line1] VARCHAR(MAX) NOT NULL, 
    [Line2] VARCHAR(MAX) NULL, 
    [City] VARCHAR(MAX) NOT NULL, 
    [State] VARCHAR(MAX) NOT NULL, 
    [ZipCode] VARCHAR(10) NOT NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null DEFAULT (getdate()),
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null 
)
