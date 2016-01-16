using System.Collections.Generic;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.WebUI.Models
{
    public class MessageOfTheDayViewModel
    {
        public IEnumerable<Message> Messages { get; set; }
        public DayOfWeekInfo DayOfWeekInfo { get; set; }
        public int LanguageId { get; set; }
    }
}