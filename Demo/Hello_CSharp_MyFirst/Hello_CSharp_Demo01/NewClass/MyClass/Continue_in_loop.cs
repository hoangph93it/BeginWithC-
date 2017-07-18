using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Continue_in_loop
{
    class Continue_in_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break in loop example.");
            int x = 1;
            while (x < 20)
            {
                Console.WriteLine("____________________\n");
                Console.WriteLine("Gia tri cua x la:{0}", x);
                if (x % 2 == 0)
                {
                    x++;
                    continue;
                }
                else
                {
                    x++;
                }
                Console.WriteLine("Gia tri cua x la:{0}", x++);
            }
            Console.ReadLine();
        }
    }
}
