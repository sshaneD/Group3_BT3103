using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {
        public static string Logout = "No";
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
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
                else
                {
                    Role = matchUser.Role;
                    Hide();
                    FormMain form = new FormMain();
                    form.ShowDialog();
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (Logout == "Yes") MessageBox.Show("You have logged out successfully.");
            Logout = "No";
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}