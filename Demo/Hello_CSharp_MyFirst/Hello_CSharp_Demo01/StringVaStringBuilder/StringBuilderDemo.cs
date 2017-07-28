using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.StringVaStringBuilder
{
    class StringBuilderDemo
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(10);
            sb.Append("Hello...");
            Console.WriteLine(sb);
            char c = '!';
            sb.Append(c);
            Console.WriteLine(sb);
            sb.Insert(8, "C#");
            Console.WriteLine(sb);
            sb.Remove(5, 3);
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
