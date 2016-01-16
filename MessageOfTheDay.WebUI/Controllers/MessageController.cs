using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MessageOfTheDay.Domain.Abstract;
using MessageOfTheDay.Domain.Entities;
using MessageOfTheDay.WebUI.Models;

namespace MessageOfTheDay.WebUI.Controllers
{
    public class MessageController : Controller
    {
        private IMessageRepository messageRepository;
        private IDayRepository dayRepository;
        
        public MessageController(IDayRepository dayRepository, IMessageRepository messageRepository)
        {
            this.dayRepository = dayRepository;
            this.messageRepository = messageRepository;
        }

        public ViewResult MessageList(int? currentDay = null, int languageId = 1)
        {
            currentDay = currentDay ?? (int) DateTime.Now.DayOfWeek;
            var model = new MessageOfTheDayViewModel
            {
                Messages = messageRepository.MessagesEnumerable
                .Where(m => m.DayId == currentDay && m.LanguageId == languageId)
            };
            return View(model);
        }
    }
}