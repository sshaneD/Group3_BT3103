CREATE TABLE [dbo].[RoomAssignments]
(
    [RoomAssignmentID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [AdmissionID] INT NOT NULL,
    [RoomID] INT NOT NULL, 
    [PatientID] INT NOT NULL, 
    [BedNumber] INT NULL,
    [StartDate] DATETIME NOT NULL,
    [EndDate] DATETIME NULL,
    FOREIGN KEY (AdmissionID) REFERENCES Admissions(AdmissionID),
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
)
