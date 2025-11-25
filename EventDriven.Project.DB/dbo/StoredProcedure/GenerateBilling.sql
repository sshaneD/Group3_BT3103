CREATE PROCEDURE [dbo].[GenerateBilling]
    @AdmissionID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PatientID INT,
            @RoomCharges DECIMAL(10,2) = 0,
            @TreatmentCharges DECIMAL(10,2) = 0,
            @MedicationCharges DECIMAL(10,2) = 0,
            @DoctorCharges DECIMAL(10,2) = 0,
            @TotalAmount DECIMAL(10,2);

    SELECT @PatientID = PatientID
    FROM Admissions
    WHERE AdmissionID = @AdmissionID;

    SELECT @RoomCharges = ISNULL(SUM((DATEDIFF(DAY, RA.StartDate, ISNULL(RA.EndDate, GETDATE())) + 1) * R.RatePerDay), 0)
    FROM RoomAssignments RA
    INNER JOIN Rooms R ON RA.RoomID = R.RoomID
    WHERE RA.AdmissionID = @AdmissionID;

    SELECT @TreatmentCharges = ISNULL(SUM(T.Price), 0)
    FROM Treatments T
    INNER JOIN MedicalRecords MR ON T.RecordID = MR.RecordID
    WHERE MR.AdmissionID = @AdmissionID;

    SELECT @MedicationCharges = ISNULL(SUM(M.FrequencyCount * (24 / NULLIF(M.FrequencyValue, 0)) * M.Duration * M.Price), 0)
    FROM Medications M
    INNER JOIN MedicalRecords MR ON M.RecordID = MR.RecordID
    WHERE MR.AdmissionID = @AdmissionID;

    SELECT @DoctorCharges = ISNULL(COUNT(*) * 800, 0)
    FROM StaffAssignment SA
    WHERE SA.PatientID = @PatientID
      AND SA.Role = 'Doctor';

    SET @TotalAmount = @RoomCharges + @TreatmentCharges + @MedicationCharges + @DoctorCharges;

    IF EXISTS (SELECT 1 FROM Billings WHERE AdmissionID = @AdmissionID)
    BEGIN
        UPDATE Billings
        SET TotalAmount = @TotalAmount,
            BillingDate = GETDATE()
        WHERE AdmissionID = @AdmissionID;
    END
    ELSE
    BEGIN
        INSERT INTO Billings (AdmissionID, PatientID, TotalAmount, AmountPaid, BillingDate)
        VALUES (@AdmissionID, @PatientID, @TotalAmount, 0, GETDATE());
    END

    SELECT 
        B.BillingID,
        B.AdmissionID,
        B.PatientID,
        B.BillingDate,
        B.TotalAmount,
        B.AmountPaid,
        B.Balance
    FROM Billings B
    WHERE B.AdmissionID = @AdmissionID;
END;
GO