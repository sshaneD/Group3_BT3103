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
        public void AddPatient(PatientModel patient)
        {
            patientRepo.AddPatient(patient);
        }
    }
}
