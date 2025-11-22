CREATE PROCEDURE [dbo].[GetAllAdmissionCards]
AS
	SELECT 
		ac.AdmissionID,
		ac.PatientID,
		CONCAT(p.FirstName, ' ', p.MiddleName, ' ', p.LastName) AS PatientName,
		mr.Diagnosis,
		ac.AdmissionDate,
		ac.DischargeDate
	FROM 
		Admissions ac
	INNER JOIN 
		Patient p ON ac.PatientID = p.PatientID
	INNER JOIN
		MedicalRecords mr ON ac.AdmissionID = mr.AdmissionID
	ORDER BY 
		ac.AdmissionDate DESC;