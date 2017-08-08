using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Enum
{
    class EnumTestJob
    {
        public static void Main(string[] args)
        {
            WeekDay today = WeekDay.MONDAY;
            if (today == WeekDay.SUNDAY)
            {
                Console.WriteLine("Today is Sunday");
            }
            else
            {
                Console.WriteLine("Today is not Sunday");
            }
            Console.ReadKey();
        }
    }
}
