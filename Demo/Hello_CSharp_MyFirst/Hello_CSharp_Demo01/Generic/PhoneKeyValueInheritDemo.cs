using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Generic
{
    class PhoneKeyValueInheritDemo
    {
        public static void Main(string[] args)
        {
            PhoneKeyValueInherit phoneinher = new PhoneKeyValueInherit(1, "Samsung");
            int id = phoneinher.GetKey();
            string name = phoneinher.GetValue();
            Console.WriteLine("This is id of phone type: " + id);
            Console.WriteLine("This is name of phone type: " + name);
            Console.ReadKey();
        }

    }
}
