namespace MessageOfTheDay.Domain.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int DayId { get; set; }
        public string TodaysMessage { get; set; }
    }
}