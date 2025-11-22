CREATE TABLE [dbo].[Billings]
(
    [BillingID] INT IDENTITY(1,1) PRIMARY KEY,
    [AdmissionID] INT NOT NULL,
    [PatientID] INT NOT NULL,
    [BillingDate] DATETIME NOT NULL,
    [Remarks] VARCHAR(MAX) NULL,
    [TotalAmount] DECIMAL(10,2) NOT NULL,
    [AmountPaid] DECIMAL(10,2) NOT NULL DEFAULT 0,
    [Balance] AS (TotalAmount - AmountPaid) PERSISTED,
    FOREIGN KEY (AdmissionID) REFERENCES Admissions(AdmissionID),
    FOREIGN KEY (PatientID) REFERENCES Patient(PatientID)
);
