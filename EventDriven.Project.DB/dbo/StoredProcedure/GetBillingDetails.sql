CREATE PROCEDURE [dbo].[GetBillingDetails]
    @AdmissionID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        RA.AdmissionID,
        R.RoomType + ' #' + CAST(R.RoomNumber AS VARCHAR(10)) AS Service,
        DATEDIFF(DAY, RA.StartDate, ISNULL(RA.EndDate, GETDATE())) + 1 AS Quantity,
        R.RatePerDay AS Price,
        (DATEDIFF(DAY, RA.StartDate, ISNULL(RA.EndDate, GETDATE())) + 1) * R.RatePerDay AS Total
    FROM RoomAssignments RA
    INNER JOIN Rooms R ON RA.RoomID = R.RoomID
    WHERE RA.AdmissionID = @AdmissionID

    UNION ALL

    SELECT 
        MR.AdmissionID,
        M.MedicationName AS Service,
        (M.FrequencyCount * (24 / M.FrequencyValue)) * M.Duration AS Quantity,
        M.Price AS Price,
        ((M.FrequencyCount * (24 / M.FrequencyValue)) * M.Duration) * M.Price AS Total
    FROM Medications M
    INNER JOIN MedicalRecords MR ON M.RecordID = MR.RecordID
    WHERE MR.AdmissionID = @AdmissionID

    UNION ALL

    SELECT
        MR.AdmissionID,
        T.TreatmentType AS Service,
        1 AS Quantity,
        T.Price AS Price,
        T.Price AS Total
    FROM Treatments T
    INNER JOIN MedicalRecords MR ON T.RecordID = MR.RecordID
    WHERE MR.AdmissionID = @AdmissionID;
END;
GO