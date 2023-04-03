CREATE TABLE [dbo].[UserRequest]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [RequestedBy] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id), 
    [RequestedTo] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id), 
    [RequestedOn] DATETIME NULL DEFAULT (getdate()), 
    [RequestStatus] INT NOT NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null DEFAULT (getdate()),
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
