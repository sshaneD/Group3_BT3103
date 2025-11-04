CREATE TABLE [dbo].[Patient]
(
	[PatientID] int IDENTITY(1000,1) primary key,
	[FirstName] varchar(50) NOT NULL,
	[MiddleName] varchar(50) NOT NULL,
	[LastName] varchar(50) NOT NULL DEFAULT GETDATE(),
	[AdmissionDate] DateTime NOT NULL,
	[DateOfBirth] DateTime NOT NULL,
	[Age] int NOT NULL,
	[Gender] varchar(50) NOT NULL,
	[GuardianName] varchar(50) NOT NULL,
	[GuardianNo] varchar(50) NOT NULL, 
    [Status] VARCHAR(50) NULL DEFAULT 'Admitted', 
   

)
