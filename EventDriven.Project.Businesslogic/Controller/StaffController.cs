using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class StaffController
    {
        StaffRepository staffRepository;
        public StaffController()
        {
            staffRepository = new StaffRepository();
        }
        public List<StaffModel> GetAllStaff()
        {
            return staffRepository.GetAllStaff();
        }
        public void AddStaff(int PatientID, int StaffID)
        {
            staffRepository.AssignStaff(PatientID, StaffID);
        }
        public StaffModel GetStaffByID(int StaffID)
        {
            return staffRepository.GetStaffByID(StaffID);
        }
        public List<int> GetAssignedStaff(int PatientID)
        {
            return staffRepository.GetAssignedStaff(PatientID);
        }
        public void RemoveAssignedStaff(int PatientID)
        {
            staffRepository.RemoveAssignedStaff(PatientID);
        }
    }
}
