using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETM.Core.Helpers
{
    public class Utilities
    {
        public static DateTime FirstDayOfYear(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, 1, 1);
        }

        public static DateTime LastDayOfYear(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, 12, 31);
        }

        public static DateTime FirstDayOfMonthFromDateTime(DateTime dateTime)
        {
             return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public static DateTime LastDayOfMonthFromDateTime(DateTime dateTime)
        {
            return (new DateTime(dateTime.Year, dateTime.Month, 1)).AddMonths(1).AddDays(-1);           
        }
    }
}
