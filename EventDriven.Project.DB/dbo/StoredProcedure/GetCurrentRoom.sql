CREATE PROCEDURE [dbo].[GetCurrentRoom]
	@PatientID INT
AS
	SELECT 
		r.RoomID,
		r.RoomType,
		r.RoomNumber,
		ra.BedNumber,
		ra.StartDate,
		ra.EndDate
	FROM 
		RoomAssignments ra
	INNER JOIN 
		Rooms r ON ra.RoomID = r.RoomID
	WHERE 
		ra.PatientID = @PatientID
    ORDER BY ra.RoomAssignmentID DESC