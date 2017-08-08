using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.DateTimeCSharp
{
    class DateTimeToString
    {
        public static void Main(string[] args)
        {
            string str_date = "dd/MM/yy";
            DateTime dt = DateTime.Now;
            string str_dt = dt.ToString(str_date);
            Console.WriteLine(str_dt);
            Console.ReadKey();
        }
    }
}
