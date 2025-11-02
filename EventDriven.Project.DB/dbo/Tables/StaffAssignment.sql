CREATE TABLE [dbo].[StaffAssignment]
(
	[StaffAssignmentID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [PatientID] INT NULL, 
    [StaffID] INT NULL, 
    [Role] NVARCHAR(50) NULL,

    CONSTRAINT [FK_StaffAssignment_Patient] 
        FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient]([PatientID]),

    CONSTRAINT [FK_StaffAssignment_Staff] 
        FOREIGN KEY ([StaffID]) REFERENCES [dbo].[Staff]([StaffID])
)
