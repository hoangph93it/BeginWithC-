using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Swtich_Case
{
    class Swtich_Case
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay lua chon loai hinh giai tri");
            Console.WriteLine("1. Play a game.");
            Console.WriteLine("2. Listen to music");
            Console.WriteLine("3. Exit.");
            int option;
            string intputStr = Console.ReadLine();
            option = Int32.Parse(intputStr);
            switch (option)
            {
                case 1:
                    Console.WriteLine("Ban da chon choi game");
                    break;
                case 2:
                    Console.WriteLine("Ban da chon nghe nhac");
                    break;
                case 3:
                    Console.WriteLine("Ban chon exit");
                    break;
            }
            Console.ReadLine();
        }
    }
}
