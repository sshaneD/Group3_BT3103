CREATE PROCEDURE [dbo].[AddValidID]
	@PatientID INT,
	@Type VARCHAR(50),
	@Name VARCHAR(100),
	@Number VARCHAR(50)
AS

	IF EXISTS (SELECT 1 FROM ValidID WHERE PatientID = @PatientID)

		UPDATE ValidID
		SET
			Type = @Type,
            Name = @Name,
            Number = @Number
        WHERE PatientID = @PatientID;

	ELSE

		INSERT INTO ValidID(PatientID, Type, Name, Number)
		VALUES (@PatientID, @Type, @Name, @Number)