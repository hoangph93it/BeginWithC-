using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Break_in_loop
{
    class Break_in_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break in loop example.");
            int x = 1;
            while (x < 20)
            {
                Console.WriteLine("____________________\n");
                Console.WriteLine("Gia tri cua x la:{0}", x);
                if (x == 10)
                {
                    break;
                }
                Console.WriteLine("Gia tri cua x sau khi break la:{0}", x = x + 1);
            }
            Console.ReadLine();
        }
    }
}
