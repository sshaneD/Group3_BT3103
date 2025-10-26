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
    }
}
