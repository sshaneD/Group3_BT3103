CREATE TABLE [dbo].[MedicalRecords]
(
	[RecordID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [AdmissionID] INT NOT NULL,
    [PatientID] INT NOT NULL,
    [RecordDate] DATETIME NOT NULL DEFAULT GETDATE(),
    [Diagnosis] VARCHAR(50) NOT NULL, 
    [Notes] VARCHAR(MAX) NULL,
    FOREIGN KEY (AdmissionID) REFERENCES Admissions(AdmissionID),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
)
