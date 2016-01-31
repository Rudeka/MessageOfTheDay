﻿using System;
using System.Linq;
using System.Web.Mvc;
using MessageOfTheDay.WebUI.Models;
using MessageOfTheDay.Domain.Abstract;

namespace MessageOfTheDay.WebUI.Controllers
{
    public class MessageController : Controller
    {
        private IMessageRepository _messageRepository;
        private ILanguageRepository _languageRepository;
        private IDayRepository _dayRepository;

        public MessageController(IMessageRepository messageRepository, ILanguageRepository languageRepository,
            IDayRepository dayRepository)
        {
            _messageRepository = messageRepository;
            _languageRepository = languageRepository;
            _dayRepository = dayRepository;
        }

        [HttpGet]
        public ActionResult List()
        {
            var todayId = ((int) DateTime.Today.DayOfWeek == 0) ? 7 : (int) DateTime.Today.DayOfWeek;
            var defaultLangId = 1;
            var model = new ContextModel()
            {
                Languages = _languageRepository.LanguagesEnumerable,
                Days = _dayRepository.DaysEnumerable,
                Messages = _messageRepository.MessagesEnumerable
                    .Where(m => m.DayId == todayId && m.LanguageId == defaultLangId),
                FlagPath = GetImagePath(defaultLangId)
            };

            return View(model);
        }

        [HttpPost]
        public ViewResult List(UserSelection userSelection)
        {
            var model = new ContextModel()
            {
                Languages = _languageRepository.LanguagesEnumerable,
                Days = _dayRepository.DaysEnumerable,
                Messages = _messageRepository.MessagesEnumerable
                    .Where(
                        m => m.DayId == userSelection.SelectedDayId && m.LanguageId == userSelection.SelectedLanguageId),
                FlagPath = GetImagePath(userSelection.SelectedLanguageId)
            };

            return View(model);
        }

        public string GetImagePath(int langId)
        {
            var language = _languageRepository.LanguagesEnumerable
            .FirstOrDefault(l => l.Id == langId);
            if (language != null)
            {
                return language.PartialFlagPath;
            }
            else
            {
                return null;
            }
        }
    }
}