CREATE PROCEDURE [dbo].[DeleteAssignedRoom]
	@PatientID INT
AS
	DELETE FROM RoomAssignments WHERE PatientID = @PatientID