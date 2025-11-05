CREATE TABLE [dbo].[MedicalRecords]
(
	[RecordID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [PatientID] INT NOT NULL,
    [RecordDate] DATETIME NOT NULL,
    [Diagnosis] VARCHAR(50) NOT NULL, 
    [Notes] VARCHAR(50) NOT NULL,
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
)
