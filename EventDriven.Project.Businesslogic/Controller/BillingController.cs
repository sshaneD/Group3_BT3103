using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class BillingController
    {
        private BillingRepository billingRepository;
        public BillingController()
        {
            billingRepository = new BillingRepository();
        }
        public BillingModel GenerateBilling(int AdmissionID)
        {
            return billingRepository.GenerateBilling(AdmissionID);
        }
        public List<BillingDetailsModel> GetBillingDetails(int AdmissionID)
        {
            return billingRepository.GetBillingDetails(AdmissionID);
        }
        public BillingModel ConfirmPayment(int BillingID, decimal AmountPaid, string Remarks)
        {
            return billingRepository.ConfirmPayment(BillingID, AmountPaid, Remarks);
        }
    }
}