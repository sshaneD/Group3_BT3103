CREATE PROCEDURE [dbo].[AddMedicalRecord]
	@PatientID INT,
	@RecordDate DATETIME,
	@Diagnosis VARCHAR(50),
	@Notes VARCHAR(MAX)
AS
	INSERT INTO MedicalRecords(AdmissionID, PatientID, RecordDate, Diagnosis, Notes)
	VALUES ((SELECT TOP 1 AdmissionID FROM Admissions WHERE Admissions.PatientID = @PatientID ORDER BY AdmissionID DESC),
	@PatientID, @RecordDate, @Diagnosis, @Notes)