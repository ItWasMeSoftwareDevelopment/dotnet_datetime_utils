using System;

namespace ItWasMe.DateTimeUtils
{
    public interface IDateTimeService
    {
        DateTime Now();
        DateTime NowUtc();
        DateTime EndOfWeek(DateTime dt);
        DateTime EndOfWeek();
        DateTime EndOfDay(DateTime dt);
        DateTime EndOfDay();
        DateTime EndOfHour(DateTime dt);
        DateTime EndOfHour();
    }

    public class DateTimeService : IDateTimeService
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }

        public DateTime NowUtc()
        {
            return DateTime.UtcNow;
        }

        /// <summary>
        /// Returns end of week from specified date
        /// </summary>
        /// <param name="dt">any day of the week</param>
        /// <returns>local date and time</returns>
        public DateTime EndOfWeek(DateTime dt)
        {
            int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
            return dt.AddDays(-1 * diff).Date.AddDays(7);
        }

        /// <summary>
        /// Returns the end of week from now (local time)
        /// </summary>
        /// <returns>local date and time</returns>
        public DateTime EndOfWeek()
        {
            return EndOfWeek(Now());
        }

        /// <summary>
        /// Returns the start of the next day according to specified date.
        /// </summary>
        /// <returns>local date and time</returns>
        public DateTime EndOfDay(DateTime dt)
        {
            return dt.AddDays(+1);
        }

        /// <summary>
        /// Returns the start of the next day from now (local time)
        /// </summary>
        /// <returns>local date and time</returns>
        public DateTime EndOfDay()
        {
            return EndOfDay(Now());
        }

        /// <summary>
        /// Returns the start of the next hour from specified
        /// </summary>
        /// <param name="dt">any date</param>
        /// <returns>local date and time</returns>
        public DateTime EndOfHour(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0, DateTimeKind.Local).AddHours(1);
        }

        /// <summary>
        /// Returns the start of the next hour from now (local time)
        /// </summary>
        /// <returns>local date and time</returns>
        public DateTime EndOfHour()
        {
            return EndOfHour(Now());
        }
    }
}
