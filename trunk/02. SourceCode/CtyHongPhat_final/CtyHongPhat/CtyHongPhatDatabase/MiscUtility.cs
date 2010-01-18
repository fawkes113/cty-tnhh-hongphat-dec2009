using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhatDatabase
{
    class MiscUtility
    {
        public static string DateTimeToString(DateTime dateTime)
        {
            string sDay = dateTime.Day < 10 ? "0" + dateTime.Day.ToString() : dateTime.Day.ToString();
            string sMonth = dateTime.Month < 10 ? "0" + dateTime.Month.ToString() : dateTime.Month.ToString();
            string sYear = dateTime.Year.ToString();
            return String.Format("'{0}/{1}/{2}'", sDay, sMonth, sYear);
        }
    }
}
