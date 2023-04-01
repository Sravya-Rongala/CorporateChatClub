CREATE TABLE [dbo].[Message]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [SenderId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id), 
    [ReceiverId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id), 
    [Body] TEXT NULL, 
    [Attachment] NVARCHAR(MAX) NULL, 
    [SentTime] DATETIME NOT NULL, 
    [IsSeen] BIT NOT NULL, 
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)