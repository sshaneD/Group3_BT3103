CREATE PROCEDURE [dbo].[GetAssignedRoom]
	@PatientID INT
AS
	SELECT * FROM RoomAssignments
	WHERE PatientID = @PatientID
