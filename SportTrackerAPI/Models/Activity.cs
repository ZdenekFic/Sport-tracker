namespace SportTrackerAPI.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public required string ActivityType { get; set; }
        public float Distance { get; set; }
        public TimeSpan Duration { get; set; }
        public int Calories { get; set; }
        public DateTime ActivityDate { get; set; }
        public required string Notes { get; set; } // Required property
    }
}
