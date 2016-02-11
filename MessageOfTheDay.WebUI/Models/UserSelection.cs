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
        public int SelectedDayId {get; set;}
        public int SelectedLanguageId { get; set; }
    }
}