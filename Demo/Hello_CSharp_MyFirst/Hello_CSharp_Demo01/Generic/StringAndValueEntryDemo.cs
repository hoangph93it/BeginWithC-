using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Generic
{
    class StringAndValueEntryDemo
    {
        public static void Main(string[] args)
        {
            StringAndValueEntry<String> em = new StringAndValueEntry<string>(1, "Phan Huu Hoang");
            int id = em.GetKey();
            string name = em.GetValue();
            Console.WriteLine("This is id of employee: " + id);
            Console.WriteLine("This is name of emoloyee: " + name);
            Console.ReadKey();
        }
    }
}
