	CREATE PROCEDURE [dbo].[EditPatient]
	
	@PatientID int,
	@FirstName Varchar(50),
	@LastName Varchar(50),
	@Age int,
	@Gender Varchar(50),
	@Diagnosis Varchar(50),
	@RoomNo int,
	@GuardianName Varchar(50),
	@GuardianNo Varchar(50)

AS
	
	Update dbo.Patient Set 
	
	FirstName = @FirstName,
	LastName = @LastName,
	Age = @Age,
	Gender = @Gender,
	Diagnosis = @Diagnosis,
	RoomNo = @RoomNo, 
	GuardianName = @GuardianName,
	GuardianNo = @GuardianName 

	Where PatientID = @PatientID