namespace EventDriven.Project.Model
{
    public class MedicalRecordModel
    {
        public int AdmissionID { get; set; }
        public int RecordID { get; set; }
        public int PatientID { get; set; }
        public DateTime RecordDate { get; set; }
        public string Diagnosis { get; set; }
        public string Notes { get; set; }
    }
}
