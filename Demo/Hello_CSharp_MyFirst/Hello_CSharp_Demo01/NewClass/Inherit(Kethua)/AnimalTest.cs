using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Inherit_Kethua_
{
    class AnimalTest
    {
        public static void Main(string[] args)
        {
            Cat tom = new Cat();
            bool isAnimal = tom is My_Inherit;
            Console.WriteLine("tom is animal?" + isAnimal);
            tom.Say();
            tom.Catch();
            Console.ReadLine();
        }
    }
}
