using System.Collections.Generic;
using MessageOfTheDay.Domain.Abstract;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Concrete
{
    public class EFLanguageRepository : ILanguageRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Language> LanguagesEnumerable
        {
            get { return context.Languages; }
        }
    }
}