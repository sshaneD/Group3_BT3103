namespace EventDriven.Project.Model
{
    public class RoomInfoModel
    {
        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal RatePerDay { get; set; }
        public int Capacity { get; set; }
    }
}
