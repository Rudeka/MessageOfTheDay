using System.Collections.Generic;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Abstract
{
    public interface IDayRepository
    {
        IEnumerable<Day> DaysEnumerable { get; }
    }
}