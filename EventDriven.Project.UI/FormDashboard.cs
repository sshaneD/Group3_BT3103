namespace EventDriven.Project.UI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormPatientInfo formPatientInfo = new FormPatientInfo();    
            formPatientInfo.ShowDialog();   
        }
    }
}
