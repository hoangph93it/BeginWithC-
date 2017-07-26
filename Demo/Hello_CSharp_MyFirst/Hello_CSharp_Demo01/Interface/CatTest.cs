using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Interface
{
    public class CatTest
    {
        public static void Main(string[] args)
        {
            Cat my_cat = new Cat("Tom");
            Console.WriteLine("Name the cat is:{0}", my_cat.GetName());
            my_cat.Eat();
            my_cat.Drink();
            bool isCat = my_cat is Cat;
            Console.WriteLine(my_cat.GetName() + " is a Cat? " + isCat);
            Console.WriteLine(my_cat.GetName() + " absolute is a Cat.");
            Console.WriteLine(my_cat.GetName() + " can be run " + my_cat.GetSpeed() + " km/h");
            Console.ReadKey();
        }
    }
}
