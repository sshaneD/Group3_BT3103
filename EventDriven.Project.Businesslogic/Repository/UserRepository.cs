using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class UserRepository
    {
        private string CONNECTIONSTRING = "Data Source=KOUTAIBA;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";

         public UserModel ValidateUser(string Username, string Password)//Form1 Validate User
        {
            
            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection Hospital = new SqlConnection(CONNECTIONSTRING))
                {
                    Hospital.Open();
                    string query = "SELECT * FROM [dbo].[User] WHERE Username = '" + Username + "' AND Password = '" + Password + "'";
                    SqlCommand command = new SqlCommand(query, Hospital);
                   

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count >= 1)
                    {
                        matchingUser = new UserModel
                        {
                            Username = Username,
                            Password = Password,
                            Role = table.Rows[0]["Role"].ToString()
                        };
                        return matchingUser;
                        

                    }                   
                }
            }

            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return null;

        }
        public UserModel getUserByUserId(string UserIdParam)
        {
            try { 
            UserModel matchingUser = new UserModel();
            using (SqlConnection myConnection = new SqlConnection(CONNECTIONSTRING))
            {
                string oString = "SELECT * FROM User WHERE Id = @userId";
                using (SqlCommand oCmd = new SqlCommand(oString, myConnection))
                {
                    oCmd.Parameters.AddWithValue("@UserId", UserIdParam);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            matchingUser.Id = (int)oReader["Id"];
                            matchingUser.Username = oReader["Username"].ToString();
                            matchingUser.Password = oReader["Password"].ToString();
                        }
                        myConnection.Close();

                    }
                }
                
            }
            
                if (matchingUser.Id == 0)
                {
                    throw new Exception("User does not exist");
                }

                return matchingUser;
            }
            
            catch (Exception ex)
            {
                
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

       
    }
}
        
    