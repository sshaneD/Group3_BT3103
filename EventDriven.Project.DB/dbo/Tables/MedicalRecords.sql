CREATE TABLE [dbo].[MedicalRecords]
(
	[RecordID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [AdmissionID] INT NOT NULL,
    [PatientID] INT NOT NULL,
    [RecordDate] DATETIME NOT NULL,
    [Diagnosis] VARCHAR(50) NOT NULL, 
    [Notes] VARCHAR(MAX) NOT NULL,
    FOREIGN KEY (AdmissionID) REFERENCES Admissions(AdmissionID),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
)
