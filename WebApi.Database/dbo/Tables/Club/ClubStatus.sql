CREATE TABLE [dbo].[ClubStatus]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [ClubId] UNIQUEIDENTIFIER NOT NULL Foreign Key References Club(Id),
    [IsActive] BIT NOT NULL DEFAULT 1, 
    [DeletedBy] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id),
    [DeletedOn] DATETIME NULL, 
    [ReactivatedBy] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id), 
    [ReactivatedOn] DATETIME NULL, 
    [DeactivatedBy] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id), 
    [DeactivatedOn] DATETIME NULL, 
    [IsReported] BIT NOT NULL DEFAULT 0, 
    [ReportedBy] UNIQUEIDENTIFIER NULL Foreign Key References Users(Id),
    [ReportedOn] DATETIME NULL, 
    [Reason] TEXT NULL,
    [CreatedBy] varchar(max) NULL,
    [CreatedOn] DateTime Null,
    [ModifiedBy] varchar(max) NUll,
    [ModifiedOn] DateTime null
)