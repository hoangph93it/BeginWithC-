using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hello_CSharp_Demo01.Multithreading
{
    public class Multithreading
    {
        public static void Main()
        {
            Console.WriteLine("Create new thread!");
            Thread newThread = new Thread(WriteB);
            Console.WriteLine("Start new thread. \n");
            newThread.Start();
            Console.WriteLine("Call write ('_') in Main Thread.... \n");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine('_');
                Thread.Sleep(50);
            }
            Console.WriteLine("Main thread finished.");
            Console.Read();
        }

        public static void WriteB()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write('B');
                Thread.Sleep(100);
            }
        }
    }
}
