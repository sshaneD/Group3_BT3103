CREATE PROCEDURE [dbo].[AddMedicalRecord]
	@PatientID INT,
	@RecordDate DATETIME,
	@Diagnosis VARCHAR(50),
	@Notes VARCHAR(MAX)
AS
	INSERT INTO MedicalRecords(PatientID, RecordDate, Diagnosis, Notes)
	VALUES (@PatientID, @RecordDate, @Diagnosis, @Notes)