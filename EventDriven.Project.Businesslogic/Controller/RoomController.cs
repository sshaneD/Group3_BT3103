using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class RoomController
    {
        private RoomRepository roomRepository;
        public RoomController()
        {
            roomRepository = new RoomRepository();
        }
        public List<RoomModel> GetRoomModel(string RoomType)
        {
            return roomRepository.GetRoomModel(RoomType);
        }
        public RoomInfoModel GetRoomByRoomID(int RoomID)
        {
            return roomRepository.GetRoomByRoomID(RoomID);
        }
        public List<RoomInfoModel> GetAllRooms()
        {
            return roomRepository.GetAllRooms();
        }
        public RoomOccupationModel GetRoomTypeAvailability(string RoomType)
        {
            return roomRepository.GetRoomTypeAvailability(RoomType);
        }
        public void AssignRoom(AssignedRoomModel assignedRoom)
        {
            roomRepository.AssignRoom(assignedRoom);
        }
        public RoomNumberModel GetRoomNumberInfo(int RoomNumber)
        {
            return roomRepository.GetRoomNumberInfo(RoomNumber);
        }
        public void DeleteAssignedRoom(int PatientID)
        {
            roomRepository.DeleteAssignedRoom(PatientID);
        }
        public List<AssignedRoomModel> GetAssignedRoom(int PatientID)
        {
            return roomRepository.GetAssignedRoom(PatientID);
        }
        public CurrentRoomModel GetCurrentRoom(int PatientID)
        {
            return roomRepository.GetCurrentRoom(PatientID);
        }
    }
}
