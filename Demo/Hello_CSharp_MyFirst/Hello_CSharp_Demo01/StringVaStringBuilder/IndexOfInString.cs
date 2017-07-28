using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.StringVaStringBuilder
{
    class IndexOfInString
    {
        public static void Main(string[] args)
        {
            string str = "Day la chuoi dung de tim vi tri cua ky tu";
            int idx = str.IndexOf('i');
            Console.WriteLine("Vi tri cua ky tu i la:{0}", idx);
            idx = str.IndexOf('d', 1);
            Console.WriteLine("Vi tri cua ky tu d tinh tu vi tri thu 4 trong chuoi tren la:{0}", idx);
            idx = str.IndexOf("vi");
            Console.WriteLine("Vi tri cua chu (vi) trong chuoi la:{0}", idx);
            Console.ReadKey();
        }
    }
}
