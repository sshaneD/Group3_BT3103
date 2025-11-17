CREATE PROCEDURE [dbo].[GetRoomNumberInfo]
    @RoomNumber INT
AS
BEGIN
    SELECT
        r.RoomID,
        COUNT(ra.PatientID) AS OccupiedBeds,
        r.Capacity
    FROM Rooms r
    LEFT JOIN RoomAssignments ra 
        ON r.RoomID = ra.RoomID
        AND ra.StartDate <= GETDATE()
        AND (ra.EndDate IS NULL OR ra.EndDate >= GETDATE())
    WHERE r.RoomNumber = @RoomNumber
    GROUP BY r.RoomID, r.Capacity;
END