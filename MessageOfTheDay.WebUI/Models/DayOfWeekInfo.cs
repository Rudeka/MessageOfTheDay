using System;
using System.Globalization;


namespace MessageOfTheDay.WebUI.Models
{
    public class DayOfWeekInfo
    {
        private static DateTime date = DateTime.Now;

        public int CurrentDayOfWeek { get; } = (int) date.DayOfWeek;
    }
}