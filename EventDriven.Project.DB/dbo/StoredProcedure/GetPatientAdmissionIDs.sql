CREATE PROCEDURE [dbo].[GetPatientAdmissionIDs]
	@PatientID INT
AS
	SELECT AdmissionID FROM Admissions WHERE PatientID = @PatientID;