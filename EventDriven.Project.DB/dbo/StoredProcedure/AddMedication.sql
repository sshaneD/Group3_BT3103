CREATE PROCEDURE [dbo].[AddMedication]
	@RecordID INT,
	@MedicationName VARCHAR(100),
	@FrequencyCount INT,
	@FrequencyValue INT,
	@FrequencyType VARCHAR(50),
	@Duration INT,
	@Price DECIMAL(10,2)
AS
	INSERT INTO Medications (RecordID, MedicationName, FrequencyCount, FrequencyValue, FrequencyType, Duration, Price)
	VALUES (@RecordID, @MedicationName, @FrequencyCount, @FrequencyValue, @FrequencyType, @Duration, @Price);