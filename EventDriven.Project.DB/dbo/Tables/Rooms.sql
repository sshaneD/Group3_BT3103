CREATE TABLE [dbo].[Rooms]
(
	[RoomID] INT NOT NULL PRIMARY KEY,
	[RoomNumber] INT NOT NULL, 
    [RoomType] VARCHAR(50) NOT NULL, 
    [RatePerDay] DECIMAL(10, 2) NOT NULL, 
    [Capacity] INT NOT NULL
)
