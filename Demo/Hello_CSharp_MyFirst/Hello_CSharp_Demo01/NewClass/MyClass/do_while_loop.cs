using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Do_while_loop
{
    class Do_while_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do wile loop example.");
            int x = 1;
            do
            {
                Console.WriteLine("Gia tri cua x la: {0}", x = x + 3);
            } while (x < 10);
            Console.ReadLine();
        }
    }
}
