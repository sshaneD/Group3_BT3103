CREATE PROCEDURE [dbo].[GetPatientMedicalRecords]
	@PatientID INT
AS
	SELECT * FROM MedicalRecords WHERE PatientID = @PatientID ORDER BY RecordID DESC;