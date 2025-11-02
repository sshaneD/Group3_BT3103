CREATE PROCEDURE [dbo].[RemoveAssignedStaff]
	@PatientID INT
AS
	DELETE FROM StaffAssignment WHERE PatientID = @PatientID