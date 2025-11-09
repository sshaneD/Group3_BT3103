CREATE PROCEDURE [dbo].[addpatient]

	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@DateOfBirth DateTime,
	@Age int,
	@Gender Varchar(50),
	@GuardianName Varchar(50),
	@GuardianNo Varchar(50)

AS
	
	INSERT INTO dbo.Patient (FirstName, MiddleName, LastName, DateOfBirth, Age, Gender, GuardianName, GuardianNo)
	VALUES (@FirstName, @MiddleName, @LastName, @DateOfBirth, @Age, @Gender, @GuardianName, @GuardianNo);

	INSERT INTO dbo.Admissions (PatientID, AdmissionDate)
	VALUES (SCOPE_IDENTITY(), GETDATE());