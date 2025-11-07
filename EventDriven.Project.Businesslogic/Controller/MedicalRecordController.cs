using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class MedicalRecordController
    {
        private MedicalRecordRepository medicalRecordRepository;
        public MedicalRecordController()
        {
            medicalRecordRepository = new MedicalRecordRepository();
        }
        public void AddMedicalRecord(MedicalRecordModel medicalRecord)
        {
            medicalRecordRepository.AddMedicalRecord(medicalRecord);
        }
        public void AddTreatment(TreatmentModel treatment)
        {
            medicalRecordRepository.AddTreatment(treatment);
        }
        public void AddMedication(MedicationModel medication)
        {
            medicalRecordRepository.AddMedication(medication);
        }
        public int GetNextMedicalRecordID()
        {
            return medicalRecordRepository.GetNextMedicalRecordID();
        }
        public MedicalRecordModel GetMedicalRecordByID(int RecordID)
        {
            return medicalRecordRepository.GetMedicalRecordByID(RecordID);
        }
        public TreatmentModel GetTreatmentByRecordID(int RecordID)
        {
            return medicalRecordRepository.GetTreatmentByRecordID(RecordID);
        }
        public MedicationModel GetMedicationByRecordID(int RecordID)
        {
            return medicalRecordRepository.GetMedicationByRecordID(RecordID);
        }
        public List<MedicalRecordModel> GetPatientMedicalRecords(int PatientID)
        {
            return medicalRecordRepository.GetPatientMedicalRecords(PatientID);
        }
    }
}
