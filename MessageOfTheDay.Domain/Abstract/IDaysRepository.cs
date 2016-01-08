using System.Collections.Generic;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Abstract
{
    public interface IDaysRepository
    {
        IEnumerable<Days> DaysEnumerable { get; }
    }
}