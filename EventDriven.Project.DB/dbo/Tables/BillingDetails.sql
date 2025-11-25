CREATE TABLE [dbo].[BillingDetails]
(
	[BillingDetailID] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [BillingID] INT NOT NULL,
    [Service] VARCHAR(100) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Price] DECIMAL(10, 2) NOT NULL, 
    [Total] AS (Quantity * Price) PERSISTED,
    FOREIGN KEY (BillingID) REFERENCES Billings(BillingID) ON DELETE CASCADE
)
