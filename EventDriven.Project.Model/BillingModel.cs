namespace EventDriven.Project.Model
{
    public class BillingModel
    {
        public int BillingID { get; set; }
        public int AdmissionID { get; set; }
        public int PatientID { get; set; }
        public DateTime BillingDate { get; set; }
        public string Remarks { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
    }
}
