using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrioDevExercise.Helpers
{
    public static class StringManip
    {
        public static string miliToDate(double startdatetime, int type = 1)
        {
            DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime date = start.AddSeconds(startdatetime).ToLocalTime();
            if (type == 1)
            {
                return date.ToString("MMM/d/yyyy");
            }
            else if (type == 2)
            {
                return date.ToString("HH:mm");
            }
            else if(type == 3)
            {
                return date.ToString("MMM d t");
            }
            else
            {
                return date.ToString("MMM d");
            }
        }
    }
}