using System.Collections.Generic;
using MessageOfTheDay.Domain.Abstract;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Concrete
{
    public class EFMessageRepository : IMessageRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<MessageForToday> MessagesEnumerable
        {
            get { return context.Messages; }
        }

    }
}