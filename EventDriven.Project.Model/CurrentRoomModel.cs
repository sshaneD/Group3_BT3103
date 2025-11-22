namespace EventDriven.Project.Model
{
    public class CurrentRoomModel
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }
        public int BedNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
