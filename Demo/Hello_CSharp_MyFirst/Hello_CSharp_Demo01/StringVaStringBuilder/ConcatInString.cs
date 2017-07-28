using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.StringVaStringBuilder
{
    class ConcatInString
    {
        public static void Main(string[] args)
        {
            string str1 = "Chuoi so 1";
            string str2 = "Chuoi so 2";
            string str3 = "Chuoi so 3";
            string s = String.Concat(str1, str2);
            Console.WriteLine("Chuoi sau khi noi la:" + s);
            Console.WriteLine("_________________________");
            string s1 = String.Concat(str1, str2, str3);
            Console.WriteLine("Chuoi s1 sau khi noi la:" + s1);
            Console.ReadKey();
        }

    }
}
