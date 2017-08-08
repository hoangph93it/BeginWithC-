using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Exception
{
    class TestAge01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please type your age here!");
            int age;
            string age_type = Console.ReadLine();
            if (Int32.TryParse(age_type, out age))
            {
                try
                {
                    CheckAge.CheckAgeEntry(age);
                    Console.WriteLine("You pass!");
                }
                catch (ToYoungException e)
                {
                    Console.WriteLine("You are too young, not pass!");
                    Console.WriteLine(e.Message);
                }
                catch (ToOldException e)
                {
                    Console.WriteLine("You are too old, not pass!");
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Tuoi nhap vao phai la chu so.");
                Console.ReadLine();
            }
        }
    }
}
