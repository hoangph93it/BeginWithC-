using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.ThuaKeTrongCSharp
{
    class Isoperator
    {
        public static void Main(string[] args)
        {
            Animal tom = new Cat("Tom", 4, 10);
            Console.WriteLine("Animail sleep:");
            tom.Sleep();
            bool isCat = tom is Cat;
            Console.WriteLine("Tom is Cat?" + isCat);
            bool isMouse = tom is Mouse;
            Console.WriteLine("Tom is Mouse?" + isMouse);
            bool isAnimal = tom is Animal;
            Console.WriteLine("Tom is Animal?" + isAnimal);
            Console.ReadKey();
        }
    }
}
