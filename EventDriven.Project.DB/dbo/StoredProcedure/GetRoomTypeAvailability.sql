CREATE PROCEDURE [dbo].[GetRoomTypeAvailability]
    @RoomType VARCHAR(50)
AS
    SELECT 
    CASE 
        WHEN COUNT(DISTINCT r.RoomID) = 1 
            THEN MAX(r.Capacity) - COUNT(ra.PatientID)
        ELSE SUM(r.Capacity) - COUNT(ra.PatientID)
    END AS TotalAvailableBeds,
    CASE 
        WHEN COUNT(DISTINCT r.RoomID) = 1 
            THEN MAX(r.Capacity)
        ELSE SUM(r.Capacity)
    END AS TotalCapacity
FROM Rooms r
LEFT JOIN RoomAssignments ra
    ON r.RoomID = ra.RoomID
    AND (ra.EndDate IS NULL)
WHERE r.RoomType = @RoomType;
