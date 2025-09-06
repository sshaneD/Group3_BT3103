using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {

        private UserController userController;

        private string CONNECTIONSTRING = "Data Source=LAPTOP-M9KS1VVV\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True;TrustServerCertificate=True";
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
            if (txtUsername.Text.Equals("Admin"))
            {
                this.Hide();
                FormDashboard formDashboard = new FormDashboard();
                formDashboard.ShowDialog();
            }
            else if (txtUsername.Text.Equals("Receptionist"))
            {
                this.Hide();
                FormDashboardFront formDashboardFront = new FormDashboardFront();
                formDashboardFront.ShowDialog();
            }
            else if (txtUsername.Text.Equals("Cashier"))
            {
                this.Hide();
                FormDashboardCashier formDashboardCashier = new FormDashboardCashier();
                formDashboardCashier.ShowDialog();
            }

            //try
            //{
            //    UserModel matchingUser = userController.ValidateUser(txtUsername.Text, txtPassword.Text);
            //    if (matchingUser != null)
            //    {
            //        this.DialogResult = DialogResult.OK;
            //        this.Close(); ;
            //    }
            //    else throw new Exception("Invalid Credentials");

            //UserModel matchingUser = new UserModel();
            //using (SqlConnection Hotel = new SqlConnection(CONNECTIONSTRING))
            //{
            //    Hotel.Open();
            //    string query = "SELECT * FROM dbo.[User] WHERE Username ='" + txtUsername.Text + "'AND Password ='" + txtPassword.Text + "'";
            //    SqlCommand command = new SqlCommand(query, Hotel);


            //    SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    if (table.Rows.Count >= 1)
            //    {
            //        this.DialogResult = DialogResult.OK;
            //        this.Close(); ;


            //    }
            //    else { MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //}
            //}

            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message);
            //}
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
