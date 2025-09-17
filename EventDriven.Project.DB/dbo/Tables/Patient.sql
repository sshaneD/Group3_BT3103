CREATE TABLE [dbo].[Patient]
(
	[PatientID] int IDENTITY(1000,1) primary key,
	[FirstName] varchar(50),
	[LastName] varchar(50),
	[Age] int,
	[Gender] varchar(50),
	[Diagnosis] varchar(50),
	[RoomNo] int,
	[GuardianName] varchar(50),
	[GuardianNo] varchar(50), 
   

)
