CREATE PROCEDURE [dbo].[GetRoomNumberInfo]
	@RoomNumber INT
AS
	SELECT
		(r.RoomID) AS RoomID,
		(SUM(ra.PatientID)) AS OccupiedBeds,
		r.Capacity
	FROM Rooms r
	INNER JOIN RoomAssignments ra ON r.RoomID = ra.RoomID
	WHERE r.RoomNumber = @RoomNumber
	GROUP BY r.RoomID, r.Capacity;