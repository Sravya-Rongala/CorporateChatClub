CREATE TABLE [dbo].[UserRequest]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [RequestedBy] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id), 
    [RequestedTo] UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES Users(Id), 
    [RequestedOn] DATETIME NOT NULL, 
    [RequestStatus] INT NOT NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)
