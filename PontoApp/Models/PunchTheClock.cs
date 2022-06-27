namespace PontoApp.Models
{
    public class PunchTheClock
    {
        public int Id { get; set; }

        public int userId { get; set; }

        public DateTime? startedIn { get; set; }

        public DateTime? finishedIn { get; set; }
    }
}