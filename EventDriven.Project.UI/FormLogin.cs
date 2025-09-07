using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {

        private UserController userController;
        private int loginAttempts = 0;

        private string CONNECTIONSTRING = "Data Source=.\\sqlexpress;Initial Catalog=userDB;Integrated Security=True;Encrypt=False";

        public FormLogin()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool loginSuccess = false;

                if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
                {
                    loginSuccess = true;
                    this.Hide();
                    FormDashboard formDashboard = new FormDashboard();
                    formDashboard.ShowDialog();
                }
                else if (txtUsername.Text.Equals("receptionist") && txtPassword.Text.Equals("reception123"))
                {
                    loginSuccess = true;
                    this.Hide();
                    FormDashboardFront formDashboardFront = new FormDashboardFront();
                    formDashboardFront.ShowDialog();
                }
                else if (txtUsername.Text.Equals("cashier") && txtPassword.Text.Equals("cashier123"))
                {
                    loginSuccess = true;
                    this.Hide();
                    FormDashboardCashier formDashboardCashier = new FormDashboardCashier();
                    formDashboardCashier.ShowDialog();
                }
                else
                {
                    // Database login validation
                    using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                    {
                        con.Open();
                        string query = "SELECT * FROM dbo.[User] WHERE Username=@username AND Password=@password";
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            loginSuccess = true;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                loginAttempts++;
                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Too many failed login attempts. Application will now close.",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Login failed ({ex.Message}). Attempts left: {3 - loginAttempts}",
                                    "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }
    }
}

           