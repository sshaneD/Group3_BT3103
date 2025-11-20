CREATE TABLE [dbo].[StaffAssignment]
(
	[StaffAssignmentID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [PatientID] INT NULL, 
    [StaffID] INT NULL, 
    [Role] NVARCHAR(50) NULL,
    FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient]([PatientID]) ON DELETE CASCADE,
    FOREIGN KEY ([StaffID]) REFERENCES [dbo].[Staff]([StaffID])
)
