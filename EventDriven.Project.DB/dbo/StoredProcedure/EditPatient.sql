	CREATE PROCEDURE [dbo].[EditPatient]
	
	@PatientID int,
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@DateOfBirth DateTime,
	@Age int,
	@Gender Varchar(50),
	@GuardianName Varchar(50),
	@GuardianNo Varchar(50)

AS
	
	Update dbo.Patient Set 
	
	FirstName = @FirstName,
	MiddleName = @MiddleName,
	LastName = @LastName,
	DateOfBirth = @DateOfBirth,
	Age = @Age,
	Gender = @Gender,
	GuardianName = @GuardianName,
	GuardianNo = @GuardianName 

	Where PatientID = @PatientID