using SQLite;

namespace WeightMe.Model
{
    public class WeightEntry
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public double Weight { get; set; }
    }
}
