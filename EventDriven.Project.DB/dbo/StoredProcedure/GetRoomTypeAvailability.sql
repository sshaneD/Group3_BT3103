CREATE PROCEDURE [dbo].[GetRoomTypeAvailability]
    @RoomType VARCHAR(50)
AS
    BEGIN
    SET NOCOUNT ON;

    -- Total capacity for all rooms of this type
    DECLARE @TotalCapacity INT = (
        SELECT SUM(Capacity)
        FROM Rooms
        WHERE RoomType = @RoomType
    );

    -- Currently occupied beds (patients assigned with no EndDate)
    DECLARE @OccupiedBeds INT = (
        SELECT COUNT(*)
        FROM RoomAssignments ra
        INNER JOIN Rooms r ON ra.RoomID = r.RoomID
        WHERE r.RoomType = @RoomType
    );

    SELECT 
        @TotalCapacity - @OccupiedBeds AS TotalAvailableBeds,
        @TotalCapacity AS TotalCapacity;
END;
