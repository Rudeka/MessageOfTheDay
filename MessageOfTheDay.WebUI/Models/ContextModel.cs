using System.Collections.Generic;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.WebUI.Models
{
    public class ContextModel
    {
        public IEnumerable<Day> Days { get; set; }

        public IEnumerable<Language> Languages { get; set; }

        public Message Message { get; set; }

        public string FlagPath { get; set; }
    }
}