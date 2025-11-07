using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControlUI
{
    public partial class MedicalRecordCard : UserControl
    {
        MedicalRecordController medicalRecordController;
        public event EventHandler UpdateMedicalRecord;
        int recordID;
        public MedicalRecordCard(int RecordID)
        {
            InitializeComponent();
            medicalRecordController = new MedicalRecordController();
            recordID = RecordID;
            LoadData(RecordID);
        }
        private void LoadData(int RecordID)
        {
            MedicalRecordModel medicalRecord = new MedicalRecordModel();
            TreatmentModel treatment = new TreatmentModel();
            MedicationModel medication = new MedicationModel();

            medicalRecord = medicalRecordController.GetMedicalRecordByID(RecordID);
            treatment = medicalRecordController.GetTreatmentByRecordID(RecordID);
            medication = medicalRecordController.GetMedicationByRecordID(RecordID);

            lblRecordID.Text = $"Record ID: {medicalRecord.RecordID}";
            lblRecordDate.Text = $"Record Date: {medicalRecord.RecordDate}";
            lblDiagnosis.Text = $"Diagnosis: {medicalRecord.Diagnosis}";
            lblTreatment.Text = $"Treatment: {treatment.TreatmentType}";
            lblMedication.Text = $"Medication: {medication.MedicationName}";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormMain.selectedRecordID = recordID;
            UpdateMedicalRecord?.Invoke(this, EventArgs.Empty);
        }
    }
}
