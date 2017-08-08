using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Generic
{
    class KeyValueDemo
    {
        public static void Main(string[] args)
        {
            KeyValue<int, string> kv = new KeyValue<int, string>(1, "C#");
            int id = kv.GetKey();
            string name = kv.GetValue();
            Console.WriteLine("This is the key and value:" + id + "/" + name);
            Console.ReadKey();
        }
    }
}
