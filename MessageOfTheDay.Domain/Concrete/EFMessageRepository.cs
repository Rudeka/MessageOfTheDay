using System.Collections.Generic;
using MessageOfTheDay.Domain.Abstract;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Concrete
{
    public class EFMessageRepository : IMessageRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Message> MessagesEnumerable
        {
            get { return context.Messages; }
        }

        public void SaveMessage(Message message)
        {
            Message dbEntry = context.Messages.Find(message.Id);

            if (dbEntry != null)
            {
                dbEntry.TodaysMessage = message.TodaysMessage;
            }

            context.SaveChanges();
        }
    }
}