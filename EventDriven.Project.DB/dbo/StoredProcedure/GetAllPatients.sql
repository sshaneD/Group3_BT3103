CREATE PROCEDURE [dbo].[GetAllPatients]
	As 
	Select 
	PatientID AS 'Patient ID',
	FirstName AS 'First Name',
	LastName AS 'Last Name',
	Age,
	Gender,
	Diagnosis,
	RoomNo AS 'Room Number',
	GuardianName AS 'Guardian Name',
	GuardianNo AS 'Guardian Number'
	From dbo.Patient