using System.Collections.Generic;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Abstract
{
    public interface IMessagesRepository
    {
        IEnumerable<Messages> MessagesesEnumerable { get; }  
    }
}