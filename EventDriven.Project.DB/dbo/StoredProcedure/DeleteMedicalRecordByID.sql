CREATE PROCEDURE [dbo].[DeleteMedicalRecordByID]
	@RecordID INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Treatments WHERE RecordID = @RecordID;
	DELETE FROM Medications WHERE RecordID = @RecordID;
	DELETE FROM MedicalRecords WHERE RecordID = @RecordID;
END	