using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class StaffRepository
    {
        private string CONNECTIONSTRING = "Data Source=jace\\sqlexpress;Initial Catalog=Hospital;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
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
                            });

                        }
                            return staffs;
                    }
                }
            }
        }
    }
}
