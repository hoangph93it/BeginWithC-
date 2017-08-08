using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.DelegrateAndEvent
{
    class StringDelegrateDemo
    {
        private delegate string DelegrateString(string s);
        public static void Main(string[] args)
        {
            StringDelegrate hello = new StringDelegrate();
            DelegrateString deStr = new DelegrateString(hello.SayHello);
            string name = deStr("Phan Huu Hoang");
            Console.WriteLine(name);
            Console.Read();
        }
    }
}