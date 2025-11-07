namespace EventDriven.Project.Model
{
    public class MedicationModel
    {
        public int MedicationID { get; set; }
        public int RecordID { get; set; }
        public string MedicationName { get; set; }
        public int FrequencyCount { get; set; }
        public int FrequencyValue { get; set; }
        public string FrequencyType { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
    }
}
