using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.ThuaKeTrongCSharp
{
    class EpKieuCSharp
    {
        public static void Main(string[] args)
        {
            Animal animal = GetRandomAnimal();
            if (animal is Cat)
            {
                Console.WriteLine("Your animal is Cat.");
                Cat cat = (Cat)animal;
                Console.WriteLine("Cat age:{0}", cat.Age);
            }
            else
            {
                Console.WriteLine("Your animal is Mouse.");
                Mouse mouse = (Mouse)animal;
                Console.WriteLine("Mouse weight:{0}", mouse.Weight);
            }
            Console.ReadKey();
        }
        public static Animal GetRandomAnimal()
        {
            int random = new Random().Next(0, 10);
            Animal animal = null;
            Console.WriteLine("Random is:{0}", random);
            if (random > 5)
            {
                Console.WriteLine("Create a Cat");
                animal = new Cat("Tom child", 1, 2);

            }
            else
            {
                Console.WriteLine("Create a Mouse");
                animal = new Mouse("Jerry child", 3);
            }
            return animal;
        }
    }

}
