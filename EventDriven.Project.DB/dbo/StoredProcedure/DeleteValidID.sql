CREATE PROCEDURE [dbo].[DeleteValidID]
	@PatientID INT
AS
	DELETE FROM ValidID WHERE PatientID = @PatientID