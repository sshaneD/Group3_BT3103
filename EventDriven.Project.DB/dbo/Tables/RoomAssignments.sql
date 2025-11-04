CREATE TABLE [dbo].[RoomAssignments]
(
    [RoomAssignmentID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [RoomID] INT NOT NULL, 
    [PatientID] INT NOT NULL, 
    [BedNumber] VARCHAR(50) NULL,
    [StartDate] DATETIME NOT NULL,
    [EndDate] DATETIME NULL,
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
)
