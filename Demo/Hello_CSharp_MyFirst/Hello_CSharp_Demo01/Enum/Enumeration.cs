using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Enum
{
    public enum WeekDay
    {
        MONDAY, TUESDAY, WEDNESDAY, THURDAY, FRIDAY, SATURDAY, SUNDAY
    }

    public class EnumTest
    {
        public static String getJob(WeekDay weekDay)
        {
            if (weekDay == WeekDay.MONDAY || weekDay == WeekDay.TUESDAY || weekDay == WeekDay.WEDNESDAY || weekDay == WeekDay.THURDAY || weekDay == WeekDay.FRIDAY)
            {
                return "Coding";
            }
            else
            {
                return "Do nothing";
            }

        }

    }
}
