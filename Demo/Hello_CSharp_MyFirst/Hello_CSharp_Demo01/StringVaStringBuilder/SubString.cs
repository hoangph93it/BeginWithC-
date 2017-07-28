using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.StringVaStringBuilder
{
    class SubString
    {
        public static void Main(string[] args)
        {
            string str = "This is text will be sub";
            string substr = str.Substring(3);
            Console.WriteLine("Substring 3 is:" + substr);
            substr = str.Substring(1, 7);
            Console.WriteLine("Substring from 1 to 7 in this text is:" + substr);
            Console.ReadKey();
        }

    }
}
