using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Exception
{
    public class Exception
    {
        public static void Main(string[] args)
        {
            int value = 10 / 2;
            Console.WriteLine(value);
            int d = 0;
            try
            {
                value = 10 / d;
                Console.WriteLine(value);
            }
            catch (System.Exception e)
            {

                Console.WriteLine("Error!" + e.Message);
            }
            Console.ReadKey();
        }

    }
}
