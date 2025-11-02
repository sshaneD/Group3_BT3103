CREATE PROCEDURE [dbo].[GetAssignedStaff]
	@PatientID INT
AS
	SELECT StaffID FROM StaffAssignment WHERE PatientID = @PatientID