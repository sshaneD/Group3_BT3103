using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class PatientRepo
    {
        private string CONNECTIONSTRING = ConfigurationHelper.GetConnectionString();
        public List<PatientModel> GetAllPatient()
        {
            try
            {
                List<PatientModel> patients = new List<PatientModel>();
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.GetAllPatients", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PatientModel patient = new PatientModel
                                {
                                    PatientID = (int)reader["PatientID"],
                                    FirstName = (string)reader["FirstName"],
                                    MiddleName = (string)reader["MiddleName"],
                                    LastName = (string)reader["LastName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Age = (int)reader["Age"],
                                    Gender = (string)reader["Gender"],
                                    GuardianName = (string)reader["GuardianName"],
                                    GuardianNo = (string)reader["GuardianNo"],
                                    Status = (string)reader["Status"]
                                };
                                patients.Add(patient);
                            }
                            return patients;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        public PatientModel GetPatientByID(int ID)
        {
            try
            {
                PatientModel patient;
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.GetPatientByID", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PatientID", ID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                patient = new PatientModel
                                {
                                    PatientID = (int)reader["PatientID"],
                                    FirstName = (string)reader["FirstName"],
                                    MiddleName = (string)reader["MiddleName"],
                                    LastName = (string)reader["LastName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Age = (int)reader["Age"],
                                    Gender = (string)reader["Gender"],
                                    GuardianName = (string)reader["GuardianName"],
                                    GuardianNo = (string)reader["GuardianNo"],
                                    Status = (string)reader["Status"]
                                };
                                return patient;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        public void EditPatient(PatientModel patient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("dbo.EditPatient", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);
                    cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", patient.MiddleName);
                    cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Age", patient.Age);
                    cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                    cmd.Parameters.AddWithValue("@GuardianName", patient.GuardianName);
                    cmd.Parameters.AddWithValue("@GuardianNo", patient.GuardianNo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
        }
        public void AddPatient(PatientModel patient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.addpatient", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                        cmd.Parameters.AddWithValue("@MiddleName", patient.MiddleName);
                        cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Age", patient.Age);
                        cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                        cmd.Parameters.AddWithValue("@GuardianName", patient.GuardianName);
                        cmd.Parameters.AddWithValue("@GuardianNo", patient.GuardianNo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public List<PatientModel> SearchPatient(string SearchTerm)
        {
            try
            {
                List<PatientModel> patients = new List<PatientModel>();
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.SearchPatient", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SearchTerm", SearchTerm);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                patients.Add(new PatientModel
                                {
                                    PatientID = (int)reader["PatientID"],
                                    FirstName = (string)reader["FirstName"],
                                    MiddleName = (string)reader["MiddleName"],
                                    LastName = (string)reader["LastName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Age = (int)reader["Age"],
                                    Gender = (string)reader["Gender"],
                                    GuardianName = (string)reader["GuardianName"],
                                    GuardianNo = (string)reader["GuardianNo"],
                                    Status = (string)reader["Status"]
                                });
                            }
                            return patients;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        public void DeletePatient(int PatientID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DeletePatient", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        public int GetNextPatientID()
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetNextPatientID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                        else return 0;
                    }
                }
            }
        }
        public List<AdmissionCardModel> GetAllAdmissionCards()
        {
            try
            {
                List<AdmissionCardModel> admissionCards = new List<AdmissionCardModel>();
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.GetAllAdmissionCards", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AdmissionCardModel admissionCard = new AdmissionCardModel
                                {
                                    AdmissionID = (int)reader["AdmissionID"],
                                    PatientID = (int)reader["PatientID"],
                                    PatientName = (string)reader["PatientName"],
                                    Diagnosis = string.IsNullOrEmpty(reader["Diagnosis"].ToString()) ? string.Empty : (string)reader["Diagnosis"],
                                    AdmissionDate = (DateTime)reader["AdmissionDate"],
                                    DischargeDate = reader["DischargeDate"] as DateTime?
                                };
                                admissionCards.Add(admissionCard);
                            }
                            return admissionCards;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        public List<int> GetPatientAdmissionIDs(int PatientID)
        {
            List<int> admissions = new List<int>();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetPatientAdmissionIDs", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            admissions.Add((int)reader["AdmissionID"]);
                    }
                }
            }
            return admissions;
        }
        public void DischargePatient(int PatientID, int AdmissionID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DischargePatient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.Parameters.AddWithValue("@AdmissionID", AdmissionID);
                    cmd.ExecuteNonQuery();

                }
            }
        }
    }
}
