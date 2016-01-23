using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MessageOfTheDay.Domain.Abstract;

namespace MessageOfTheDay.WebUI.Models
{
    public class DropdownInfo
    {
        private IDayRepository dayRepository;
        private ILanguageRepository languageRepository;

        public DropdownInfo(IDayRepository dayRepository, ILanguageRepository languageRepository)
        {
            this.dayRepository = dayRepository;
            this.languageRepository = languageRepository;
        }

        public int SelectedDayId { get; set; }
        public int SelectedLanguageId { get; set; }

        public List<SelectListItem> GetDays()
        {
            var days = new List<SelectListItem>();

            foreach (var day in dayRepository.DaysEnumerable)
            {
                days.Add(new SelectListItem { Text = day.Name, Value = day.Id.ToString() });
            }

            return days;
        }

        public List<SelectListItem> GetLanguages()
        {
            var languages = new List<SelectListItem>();

            foreach (var language in languageRepository.LanguagesEnumerable)
            {
                languages.Add(new SelectListItem { Text = language.Name, Value = language.Id.ToString() });
            }

            return languages;
        } 
    }
}