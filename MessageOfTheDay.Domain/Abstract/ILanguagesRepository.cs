using System.Collections.Generic;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Abstract
{
    public interface ILanguagesRepository
    {
        IEnumerable<Languages> LanguagesEnumerable { get; }
    }
}