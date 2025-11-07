CREATE PROCEDURE [dbo].[GetMedicalRecordByID]
	@RecordID INT
AS
	SELECT * FROM MedicalRecords WHERE RecordID = @RecordID;