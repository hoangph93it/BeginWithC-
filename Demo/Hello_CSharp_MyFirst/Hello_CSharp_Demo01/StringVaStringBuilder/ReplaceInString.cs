using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.StringVaStringBuilder
{
    class ReplaceInString
    {
        public static void Main(string[] args)
        {
            string str = "This is text will be replace.";
            string restr = str.Replace("is", "iss");
            Console.WriteLine("This is text after replace:" + restr);
            string refirst = ReplaceFirst(str, "is", "isss");
            Console.WriteLine("This text after replace first charactor is:" + refirst);
            Console.ReadKey();
        }
        static string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
