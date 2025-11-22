namespace EventDriven.Project.Model
{
    public class BillingDetailsModel
    {
        public int AdmissionID { get; set; }
        public string Service { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
