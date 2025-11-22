CREATE PROCEDURE [dbo].[DeletePatient]
	@PatientID INT
AS 
	DELETE FROM Patient WHERE PatientID = @PatientID