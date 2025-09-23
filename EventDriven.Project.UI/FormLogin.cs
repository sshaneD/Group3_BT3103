using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {

        private UserController userController;
        private int loginAttempts = 3;
        public static String Role;

        public FormLogin()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool loginSuccess;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                UserModel matchUser = userController.ValidateUser(txtUsername.Text, txtPassword.Text);

                if (matchUser == null)
                {
                    loginAttempts--;
                    if (loginAttempts <= 0)
                    {
                        MessageBox.Show("Too many failed login attempts. Application will now close.",
                                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials. You have " + loginAttempts + " more attempts.");
                    }
                }
                else if (matchUser != null)
                {
                    Role = matchUser.Role;
                    if (matchUser.Role == "admin")
                    {
                        this.Hide();
                        FormDashboard formDashboard = new FormDashboard();
                        formDashboard.ShowDialog();
                    }
                    else if (matchUser.Role == "cashier")
                    {
                        this.Hide();
                        FormDashboardCashier formDashboardCashier = new FormDashboardCashier();
                        formDashboardCashier.ShowDialog();
                    }
                    else if (matchUser.Role == "receptionist")
                    {
                        this.Hide();
                        FormDashboardFront formDashboardFront = new FormDashboardFront();
                        formDashboardFront.ShowDialog();
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

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}