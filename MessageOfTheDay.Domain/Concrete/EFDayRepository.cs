using System.Collections.Generic;
using MessageOfTheDay.Domain.Abstract;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Concrete
{
    public class EFDayRepository : IDayRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Day> DaysEnumerable
        {
            get { return context.Days; }
        }
    }
}