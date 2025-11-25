CREATE PROCEDURE [dbo].[GetAllAdmissionCards]
AS
BEGIN
    SELECT 
        ac.AdmissionID,
        ac.PatientID,
        CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS PatientName,
        mr.Diagnosis,
        ac.AdmissionDate,
        ac.DischargeDate
    FROM Admissions ac
    INNER JOIN Patient p 
        ON ac.PatientID = p.PatientID
    LEFT JOIN (
        SELECT 
            AdmissionID,
            Diagnosis,
            RecordDate,
            ROW_NUMBER() OVER (PARTITION BY AdmissionID ORDER BY RecordDate DESC) AS rn
        FROM MedicalRecords
    ) mr ON ac.AdmissionID = mr.AdmissionID AND mr.rn = 1
    ORDER BY ac.AdmissionDate DESC;
END;
GO
