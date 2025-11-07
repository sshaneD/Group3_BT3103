CREATE PROCEDURE [dbo].[GetMedicationByRecordID]
	@RecordID INT
AS
	SELECT * FROM Medications WHERE RecordID = @RecordID;
