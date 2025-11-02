CREATE PROCEDURE [dbo].[GetNextPatientID]
AS
	SELECT IDENT_CURRENT('Patient') + IDENT_INCR('Patient') AS NextID;
