using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Exception
{
    class CheckAge
    {
        public static void CheckAgeEntry(int age)
        {
            if (age <= 15)
            {
                throw new ToYoungException("Age " + age + " Too young!");
            }
            else if (age >= 60)
            {
                throw new ToOldException("Age " + age + " Too old!");
            }
            Console.WriteLine("Age " + age + " is OK!");
        }
    }
}
