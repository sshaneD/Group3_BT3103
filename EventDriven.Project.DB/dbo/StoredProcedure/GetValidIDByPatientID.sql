CREATE PROCEDURE [dbo].[GetValidIDByPatientID]
	@PatientID INT
AS
	SELECT * FROM ValidID WHERE PatientID = @PatientID
