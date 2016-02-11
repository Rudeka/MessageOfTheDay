using System.Collections.Generic;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Abstract
{
    public interface IMessageRepository
    {
        IEnumerable<Message> MessagesEnumerable { get; }

        void SaveMessage(Message message);
    }
}