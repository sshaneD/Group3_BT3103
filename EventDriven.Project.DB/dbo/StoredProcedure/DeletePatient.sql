CREATE PROCEDURE [dbo].[DeletePatient]
	@PatientID int 
	as 
	Delete From Patient where PatientID = @PatientID