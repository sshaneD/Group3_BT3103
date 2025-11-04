using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class RoomOccupationModel
    {
        public string RoomType { get; set; }
        public int TotalAvailableBeds { get; set; }
        public int Capacity { get; set; }
    }
}
