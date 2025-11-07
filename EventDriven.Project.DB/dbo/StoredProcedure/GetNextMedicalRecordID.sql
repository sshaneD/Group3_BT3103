CREATE PROCEDURE [dbo].[GetNextMedicalRecordID]
AS
	SELECT CAST(IDENT_CURRENT('MedicalRecords') + IDENT_INCR('MedicalRecords') AS INT) AS NextID;