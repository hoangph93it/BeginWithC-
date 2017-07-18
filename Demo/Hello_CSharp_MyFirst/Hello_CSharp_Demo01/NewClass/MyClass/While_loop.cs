using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.While_loop
{
    class Wihle_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wile loop example.");
            int x = 1;
            while (x < 20)
            {
                Console.WriteLine("Gia tri cua x la: {0}", x);
                x = x + 1;
            }
            Console.ReadLine();
        }
    }
}
