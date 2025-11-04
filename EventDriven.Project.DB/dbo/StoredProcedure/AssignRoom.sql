CREATE PROCEDURE [dbo].[AssignRoom]
	@RoomID INT,
	@PatientID INT,
	@BedNumber VARCHAR(50),
	@StartDate DATETIME,
	@EndDate DATETIME = NULL
AS
	INSERT INTO RoomAssignments (RoomID, PatientID, BedNumber, StartDate, EndDate)
	VALUES (@RoomID, @PatientID, @BedNumber, @StartDate, @EndDate)