using System.Data.Entity;
using MessageOfTheDay.Domain.Entities;

namespace MessageOfTheDay.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Day> Days { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MessageForToday> Messages { get; set; }
    }
}