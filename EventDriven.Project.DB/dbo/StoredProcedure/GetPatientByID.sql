CREATE PROCEDURE [dbo].[GetPatientByID]
	
	@PatientID int

AS

	SELECT * FROM dbo.Patient WHERE PatientID = @PatientID