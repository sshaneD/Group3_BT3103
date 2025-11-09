CREATE TABLE [dbo].[AdmissionHistory]
(
	[AdmissionID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[PatientID] INT NOT NULL,
	[AdmissionDate] DATETIME NOT NULL,
	[DischargeDate] DATETIME NULL,
	[TotalBill] DECIMAL(18, 2) NOT NULL,
	[Balance] DECIMAL(18, 2) NOT NULL
)
