CREATE PROCEDURE [dbo].[AssignRoom]
	@RoomID INT,
	@PatientID INT,
	@BedNumber INT,
	@StartDate DATETIME,
	@EndDate DATETIME = NULL
AS
	INSERT INTO RoomAssignments (AdmissionID, RoomID, PatientID, BedNumber, StartDate, EndDate)
	VALUES ((SELECT TOP 1 AdmissionID FROM Admissions WHERE Admissions.PatientID = @PatientID ORDER BY AdmissionID DESC),
	@RoomID, @PatientID, @BedNumber, @StartDate, @EndDate)