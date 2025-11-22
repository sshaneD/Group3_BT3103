CREATE PROCEDURE [dbo].[ConfirmPayment]
	@BillingID INT,
	@AmountPaid DECIMAL(10,2),
	@Remarks VARCHAR(MAX)
AS
BEGIN
	UPDATE Billings
		SET 
			AmountPaid = AmountPaid + @AmountPaid,
			Remarks = @Remarks,
			BillingDate = GETDATE()
		WHERE BillingID = @BillingID

	SELECT * FROM Billings WHERE BillingID = @BillingID;
END