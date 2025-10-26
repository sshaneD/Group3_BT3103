CREATE TABLE [dbo].[RoomAssignments]
(
    [RoomAssignmentID] INT NULL, 
    [RoomID] INT NOT NULL, 
    [PatientID] INT NOT NULL, 
    [Bed Number] INT NULL
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
)
