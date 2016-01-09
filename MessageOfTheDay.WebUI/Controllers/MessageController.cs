using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MessageOfTheDay.Domain.Abstract;

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

        public ViewResult MessageList()
        {
            return View(dayRepository.DaysEnumerable);
        }
    }
}