using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class StaffRepository
    {
        private string CONNECTIONSTRING = "Data Source=KOUTAIBA;Initial Catalog=STEF;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        public List<StaffModel> GetAllStaff()
        {
            List<StaffModel> staffs = new List<StaffModel>();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllStaff", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staffs.Add(new StaffModel()
                            {
                                StaffID = reader.GetInt32(0),
                                DepartmentName = reader.GetString(1),
                                FirstName = reader.GetString(2),
                                LastName = reader.GetString(3),
                                Role = reader.GetString(4),
                                Shift = reader.GetString(5)
                            });

                        }
                            return staffs;
                    }
                }
            }
        }
        public void AssignStaff(int PatientID, int StaffID)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AssignStaff", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.Parameters.AddWithValue("@StaffID", StaffID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public StaffModel GetStaffByID(int StaffID)
        {
            StaffModel staff = new StaffModel();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetStaffByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StaffID", StaffID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            staff.StaffID = reader.GetInt32(0);
                            staff.DepartmentName = reader.GetString(1);
                            staff.FirstName = reader.GetString(2);
                            staff.LastName = reader.GetString(3);
                            staff.Role = reader.GetString(4);
                            staff.Shift = reader.GetString(5);
                        }
                    }
                }
            }
            return staff;
        }
        public List<int> GetAssignedStaff(int PatientID)
        {
            List<int> staffIDs = new List<int>();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetAssignedStaff", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staffIDs.Add(reader.GetInt32(0));
                        }
                        return staffIDs;
                    }
                }
            }
        }

        public void RemoveAssignedStaff(int PatientID)
        {
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("RemoveAssignedStaff", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
