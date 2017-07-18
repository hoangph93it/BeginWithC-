using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.For_loop
{
    class For_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# for loop example");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Gia tri cua i la: {0}", i);
            }
            for (int i = 0; i < 20; i = i + 4)
            {
                Console.WriteLine("Gia tri cua i la: {0}", i);
            }
            Console.ReadLine();
        }
    }
}
