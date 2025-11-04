CREATE PROCEDURE [dbo].[GetRoomModel]
    @RoomType VARCHAR(50)
AS

    SELECT 
        r.RoomNumber,
        r.Capacity AS BedNumbers,
        COUNT(ra.PatientID) AS OccupiedBeds,
        (r.Capacity - COUNT(ra.PatientID)) AS AvailableBeds
    FROM Rooms r
    LEFT JOIN RoomAssignments ra
        ON r.RoomID = ra.RoomID
    WHERE r.RoomType = @RoomType
    GROUP BY r.RoomNumber, r.Capacity
    ORDER BY r.RoomNumber