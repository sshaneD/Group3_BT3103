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
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
