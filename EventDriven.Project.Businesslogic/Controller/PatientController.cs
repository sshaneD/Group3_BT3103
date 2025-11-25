using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class PatientController
    {
        PatientRepo patientRepo;
        public PatientController()
        {
            patientRepo = new PatientRepo();
        }
        public List<PatientModel> GetAllPatients()
        {
            return patientRepo.GetAllPatient();
        }

        public void EditPatient(PatientModel patient)
        {
            patientRepo.EditPatient(patient);
        }

        public PatientModel GetPatientById(int id)
        {
            return patientRepo.GetPatientByID(id);
        }
        public void AddPatient(PatientModel patient)
        {
            patientRepo.AddPatient(patient);
        }
        public List<PatientModel> SearchPatient(string SearchTerm)
        {
            return patientRepo.SearchPatient(SearchTerm);
        }
        public void DeletePatient(int PatientID)
        {
            patientRepo.DeletePatient(PatientID);
        }
        public int GetNextPatientID()
        {
            return patientRepo.GetNextPatientID();
        }
        public List<AdmissionCardModel> GetAllAdmissionCards()
        {
            return patientRepo.GetAllAdmissionCards();
        }
        public List<int> GetPatientAdmissionIDs(int PatientID)
        {
            return patientRepo.GetPatientAdmissionIDs(PatientID);
        }
        public void DischargePatient(int PatientID, int AdmissionID)
        {
            patientRepo.DischargePatient(PatientID, AdmissionID);
        }
        public void AddValidID(ValidIDModel validID)
        {
            patientRepo.AddValidID(validID);
        }
        public ValidIDModel GetValidIDByPatientID(int PatientID)
        {
            return patientRepo.GetValidIDByPatientID(PatientID);
        }
        public void DeleteValidID(int PatientID)
        {
            patientRepo.DeleteValidID(PatientID);
        }
    }
}
