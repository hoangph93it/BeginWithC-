using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.ThuaKeTrongCSharp
{
    class CatTest
    {
        public static void Main(string[] args)
        {
            Cat my_cat = new Cat("Miumiu", 4, 5);
            Console.WriteLine("This is my cat.");
            Console.WriteLine("Her name is:{0}", my_cat.Name);
            Console.WriteLine("Her age is:{0}", my_cat.Age);
            Console.WriteLine("Her weight is:{0}", my_cat.Weight);
            my_cat.Move();
            my_cat.Say();
            Console.ReadLine();
        }
    }
}
