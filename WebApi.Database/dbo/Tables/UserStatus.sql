CREATE TABLE [dbo].[UserStatus]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [UserId] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id),
    [IsActive] BIT NOT NULL DEFAULT 1, 
    [DeactivatedBy] UNIQUEIDENTIFIER NULL FOREIGN KEY REFERENCES Users(Id), 
    [DeactivatedOn] DATETIME NULL, 
    [ReactivatedBy] UNIQUEIDENTIFIER NULL FOREIGN KEY REFERENCES Users(Id), 
    [ReactivatedOn] DATETIME NULL, 
    [Reason] TEXT NULL, 
    [DeletedBy] UNIQUEIDENTIFIER NULL FOREIGN KEY REFERENCES Users(Id), 
    [DeletedOn] DATETIME NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
