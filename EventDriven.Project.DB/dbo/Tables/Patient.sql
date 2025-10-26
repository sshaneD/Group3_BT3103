CREATE TABLE [dbo].[Patient]
(
	[PatientID] int IDENTITY(1000,1) primary key,
	[FirstName] varchar(50),
	[MiddleName] varchar(50),
	[LastName] varchar(50),
	[AdmissionDate] DateTime,
	[DateOfBirth] DateTime,
	[Age] int,
	[Gender] varchar(50),
	[GuardianName] varchar(50),
	[GuardianNo] varchar(50), 
   

)
