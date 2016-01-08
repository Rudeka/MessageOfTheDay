namespace MessageOfTheDay.Domain.Entities
{
    public class Messages
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int DayId { get; set; }
        public string Message { get; set; }
    }
}