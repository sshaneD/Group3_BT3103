CREATE TABLE [dbo].[Medications]
(
	[MedicationID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[RecordID] INT NOT NULL,
	[MedicationName] VARCHAR(100) NOT NULL,
	[FrequencyValue] INT NOT NULL,
	[FrequencyType] VARCHAR(50) NOT NULL,
	[Duration] INT NOT NULL,
	[Price] DECIMAL(10,2) NOT NULL,
	FOREIGN KEY (RecordID) REFERENCES MedicalRecords(RecordID)
)
