using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Exception
{
    class TestAge02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plase enter your age!");
            int age;
            string age_entry = Console.ReadLine();
            if (int.TryParse(age_entry, out age))
            {
                try
                {
                    CheckAge.CheckAgeEntry(age);
                    Console.WriteLine("Pass!");
                }
                catch (AgeException e)
                {
                    Console.WriteLine("Reject!");
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your age type in must be a number!");
                Console.ReadLine();
            }
        }
    }
}
