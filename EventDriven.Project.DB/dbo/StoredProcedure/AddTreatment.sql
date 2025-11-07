CREATE PROCEDURE [dbo].[AddTreatment]
	@RecordID INT,
	@TreatmentType VARCHAR(50),
	@Price DECIMAL(10,2)
AS
	INSERT INTO Treatments (RecordID, TreatmentType, Price)
	VALUES (@RecordID, @TreatmentType, @Price);