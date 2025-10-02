using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class PatientRepo
    {
        private string CONNECTIONSTRING = "Data Source=jace\\sqlexpress;Initial Catalog=master;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public List <PatientModel> GetAllPatient()
        {
            try
            {
                List<PatientModel> patients = new List<PatientModel>();
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.GetAllPatients", conn)) {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read()) {
                                patients.Add(new PatientModel {
                                    PatientID = (int)reader["PatientID"],
                                    FirstName = (string)reader["FirstName"],
                                    LastName = (string)reader["LastName"],
                                    Age = (int)reader["Age"],
                                    Gender = (string)reader["Gender"],
                                    Diagnosis = (string)reader["Diagnosis"],
                                    RoomNo = (int)reader["RoomNo"],
                                    GuardianName = (string)reader["GuardianName"],
                                    GuardianNo = (string)reader["GuardianNo"],
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

        public void AddPatient(PatientModel patient) 
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("dbo.addpatient", conn);
                    
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                    cmd.Parameters.AddWithValue("@Age", patient.Age);
                    cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                    cmd.Parameters.AddWithValue("@Diagnosis", patient.Diagnosis);
                    cmd.Parameters.AddWithValue("@RoomNo", patient.RoomNo);
                    cmd.Parameters.AddWithValue("@GuardianName", patient.GuardianName);
                    cmd.Parameters.AddWithValue("@GuardianNo", patient.GuardianNo);
                    cmd.ExecuteNonQuery();


                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
