using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.StringVaStringBuilder
{
    class LengthInString
    {
        public static void Main(string[] args)
        {
            String str = "Kiem tra do dai cua mot String";
            int leng = str.Length;
            Console.WriteLine("Do dai cua String ben tren la:{0}", leng);
            Console.ReadKey();
        }
    }
}
