using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.WebUI.Models
{
    public class ShowDropdownsModel
    {
        private IEnumerable<Day> days;

        private IEnumerable<Language> languages;

        public ShowDropdownsModel(IEnumerable<Day> days, IEnumerable<Language> languages)
        {
            this.days = days;
            this.languages = languages;
        }

        public ShowDropdownsModel()
        {

        }

        public int SelectedDayId = (int)DateTime.Today.DayOfWeek == 0 ? 7 : (int)DateTime.Today.DayOfWeek;
        public int SelectedLanguageId = 1;

        public SelectListItem[] Languages
        {
            get
            {
                return languages.Select(l => new SelectListItem { Text = l.Name, Value = l.Id.ToString() }).ToArray();
            }
        }

        public SelectListItem[] Days
        {
            get
            {
                return days.Select(d => new SelectListItem { Text = d.Name, Value = d.Id.ToString() }).ToArray();
            }
        }
    }
}