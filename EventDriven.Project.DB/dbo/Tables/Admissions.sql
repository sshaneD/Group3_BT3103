CREATE TABLE [dbo].[Admissions]
(
	[AdmissionID] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[PatientID] INT NOT NULL,
	[AdmissionDate] DATETIME NOT NULL,
	[DischargeDate] DATETIME NULL,
	FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient]([PatientID])
)
