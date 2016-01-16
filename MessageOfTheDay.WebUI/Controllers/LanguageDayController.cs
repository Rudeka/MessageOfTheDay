using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MessageOfTheDay.Domain.Abstract;

namespace MessageOfTheDay.WebUI.Controllers
{
    public class LanguageDayController : Controller
    {
        private IDayRepository dayRepository;
        private ILanguageRepository languageRepository;

        public LanguageDayController(IDayRepository dayRepository, ILanguageRepository languageRepository)
        {
            this.dayRepository = dayRepository;
            this.languageRepository = languageRepository;
        }

        public PartialViewResult DayMenu()
        {
            IEnumerable<int> dayIDs = dayRepository.DaysEnumerable
                .Select(x => x.Id);
            return PartialView(dayIDs);
        }

        public PartialViewResult LanguageMenu()
        {
            IEnumerable<int> languageIDs = languageRepository.LanguagesEnumerable
                .Select(x => x.Id);
            return PartialView(languageIDs);
        }
    }
}