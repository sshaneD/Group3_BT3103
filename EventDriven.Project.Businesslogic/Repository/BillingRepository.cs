using System.Data;
using System.Data.SqlClient;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class BillingRepository
    {
        private string CONNECTIONSTRING = ConfigurationHelper.GetConnectionString();
        public BillingModel GenerateBilling (int AdmissionID)
        {
            BillingModel billing = new BillingModel();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GenerateBilling", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdmissionID", AdmissionID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            billing = new BillingModel()
                            {
                                BillingID = (int)reader["BillingID"],
                                AdmissionID = (int)reader["AdmissionID"],
                                PatientID = (int)reader["PatientID"],
                                TotalAmount = (decimal)reader["TotalAmount"],
                                AmountPaid = (decimal)reader["AmountPaid"],
                                Balance = (decimal)reader["Balance"],
                                BillingDate = (DateTime)reader["BillingDate"]
                            };
                        }
                    }
                }
            }
            return billing;
        }
        public List<BillingDetailsModel> GetBillingDetails(int AdmissionID)
        {
            List<BillingDetailsModel> billingDetails = new List<BillingDetailsModel>();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetBillingDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdmissionID", AdmissionID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            billingDetails.Add(new BillingDetailsModel()
                            {
                                AdmissionID = (int)reader["AdmissionID"],
                                Service = (string)reader["Service"],
                                Quantity = (int)reader["Quantity"],
                                Price = (decimal)reader["Price"],
                                Total = (decimal)reader["Total"]
                            });
                        }
                    }
                }
            }
            return billingDetails;
        }
        public BillingModel ConfirmPayment(int BillingID, decimal AmountPaid, string Remarks)
        {
            BillingModel billingModel = new BillingModel();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ConfirmPayment", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BillingID", BillingID);
                    cmd.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                    cmd.Parameters.AddWithValue("@Remarks", Remarks);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            billingModel = new BillingModel()
                            {
                                BillingID = (int)reader["BillingID"],
                                AdmissionID = (int)reader["AdmissionID"],
                                PatientID = (int)reader["PatientID"],
                                BillingDate = (DateTime)reader["BillingDate"],
                                Remarks = (string)reader["Remarks"],
                                TotalAmount = (decimal)reader["TotalAmount"],
                                AmountPaid = (decimal)reader["AmountPaid"],
                                Balance = (decimal)reader["Balance"]
                            };
                        }
                    }
                }
            }
            return billingModel;
        }
    }
}
