CREATE TABLE [dbo].[Message]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [SenderId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Users(Id), 
    [ReceiverId] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id), 
    [ClubId] UNIQUEIDENTIFIER NULL Foreign Key References Club(Id), 
    [Body] TEXT NULL, 
    [Attachment] NVARCHAR(MAX) NULL, 
    [SentTime] DATETIME NULL DEFAULT (getdate()), 
    [IsSeen] BIT NOT NULL DEFAULT 0, 
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null DEFAULT (getdate()),
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)