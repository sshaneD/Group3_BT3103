CREATE PROCEDURE [dbo].[SearchPatient]
	@searchTerm nvarchar(50)
	as 
	select 
	PatientID AS 'Patient ID',
	FirstName AS 'First Name',
	LastName AS 'Last Name',
	Age,
	Gender,
	Diagnosis,
	RoomNo AS 'Room Number',
	GuardianName AS 'Guardian Name',
	GuardianNo AS 'Guardian Number'
	from Patient
	Where FirstName like '%' + @searchTerm + '%'
	or LastName like '%' + @searchTerm + '%'
	or Cast(PatientID as nvarchar(50)) like '%' + @searchTerm + '%'
