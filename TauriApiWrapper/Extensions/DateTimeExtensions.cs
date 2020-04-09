using System;
using System.Collections.Generic;
using System.Text;

namespace TauriApiWrapper.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime FromUnixTimeStamp(this double value)
        {
            DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            date = date.AddSeconds(value).ToLocalTime();
            return date;
        }
    }
}