using System.Collections.Generic;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Abstract
{
    public interface ILanguageRepository
    {
        IEnumerable<Language> LanguagesEnumerable { get; }
    }
}