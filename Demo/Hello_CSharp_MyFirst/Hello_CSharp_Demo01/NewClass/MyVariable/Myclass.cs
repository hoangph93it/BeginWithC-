using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.MyVariable
{
    class Myclass
    {
        static void Main(string[] args)
        {
            string studentName = "Phan Huu Hoang";
            const int maxScore = 100;
            int stuScore = 60;
            Console.WriteLine("Xin cho sinh vien {0}", studentName);
            Console.Write("Diem cua ban la {0}/{1}", maxScore, stuScore);
            Console.ReadLine();
        }
    }
}
