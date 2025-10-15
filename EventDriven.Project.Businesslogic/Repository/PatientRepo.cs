using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class PatientRepo
    {
        private string CONNECTIONSTRING = "Data Source=KOUTAIBA;Initial Catalog=STEF;Integrated Security=True;TrustServerCertificate=True";

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
                                    LastName = (string)reader["LastName"],
                                    Age = (int)reader["Age"],
                                    Gender = (string)reader["Gender"],
                                    Diagnosis = (string)reader["Diagnosis"],
                                    RoomNo = (int)reader["RoomNo"],
                                    GuardianName = (string)reader["GuardianName"],
                                    GuardianNo = (string)reader["GuardianNo"],
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
            catch (Exception ex) 
            {
                Debug.WriteLine (ex.Message);
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
    }
}
