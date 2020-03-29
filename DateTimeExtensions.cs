using System;

namespace ItWasMe.DateTimeUtils
{
    public static class DateTimeExtensions
    {
        public static long UnixTimestampFromDateTime(this DateTime date)
        {
            var unixTimestamp = date.Ticks - new DateTime(1970, 1, 1).Ticks;
            unixTimestamp /= TimeSpan.TicksPerSecond;
            return unixTimestamp;
        }
    }
}
