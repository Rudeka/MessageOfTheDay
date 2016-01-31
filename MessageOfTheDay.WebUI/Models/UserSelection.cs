using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MessageOfTheDay.Domain.Abstract;
using MessageOfTheDay.Domain.Concrete;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.WebUI.Models
{
    public class UserSelection
    {
        private IEnumerable<Day> days;

        private IEnumerable<Language> languages;

        public UserSelection(IEnumerable<Day> days, IEnumerable<Language> languages)
        {
            this.days = days;
            this.languages = languages;
        }

        public UserSelection()
        {
           
        }

        private int selectedDayId = (int)DateTime.Today.DayOfWeek == 0 ? 7 : (int)DateTime.Today.DayOfWeek;
        
        public int SelectedDayId
        {
            get  { return selectedDayId; }
            set { selectedDayId = value; }
        }
        public int SelectedLanguageId { get; set; } = 1;

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