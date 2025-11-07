CREATE PROCEDURE [dbo].[GetTreatmentByRecordID]
	@RecordID INT
AS
	SELECT * FROM Treatments WHERE RecordID = @RecordID