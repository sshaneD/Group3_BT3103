CREATE PROCEDURE [dbo].[GetRoomModel]
    @RoomType VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        r.RoomNumber,
        r.Capacity AS BedNumbers,

        -- Count only ACTIVE stays
        COUNT(CASE 
                WHEN ra.StartDate <= GETDATE()
                 AND (ra.EndDate IS NULL OR ra.EndDate >= GETDATE())
                THEN ra.PatientID 
              END) AS OccupiedBeds,

        -- Compute AvailableBeds dynamically
        r.Capacity -
        COUNT(CASE 
                WHEN ra.StartDate <= GETDATE()
                 AND (ra.EndDate IS NULL OR ra.EndDate >= GETDATE())
                THEN ra.PatientID 
              END) AS AvailableBeds

    FROM Rooms r
    LEFT JOIN RoomAssignments ra
        ON r.RoomID = ra.RoomID
    WHERE r.RoomType = @RoomType

    GROUP BY r.RoomNumber, r.Capacity
    ORDER BY r.RoomNumber;
END;
