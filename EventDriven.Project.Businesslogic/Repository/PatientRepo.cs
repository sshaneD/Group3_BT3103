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
    }
}
