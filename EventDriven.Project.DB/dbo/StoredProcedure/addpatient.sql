CREATE PROCEDURE [dbo].[addpatient]

	@FirstName Varchar(50),
	@LastName Varchar(50),
	@Age int,
	@Gender Varchar(50),
	@Diagnosis Varchar(50),
	@RoomNo int,
	@GuardianName Varchar(50),
	@GuardianNo Varchar(50)

AS
	
	INSERT INTO dbo.Patient (FirstName, LastName, Age, Gender, Diagnosis, RoomNo, GuardianName, GuardianNo)
	VALUES (@FirstName, @LastName, @Age, @Gender, @Diagnosis, @RoomNo, @GuardianName, @GuardianNo)