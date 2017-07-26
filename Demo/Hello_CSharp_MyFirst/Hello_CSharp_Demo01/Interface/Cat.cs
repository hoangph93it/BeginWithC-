using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Interface
{
    public class Cat : Animal, DrinkInterface, EatInterface
    {
        private string Name;
        public Cat(String name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public override void Back()
        {
            Console.WriteLine(Name + "is back");
        }
        public override int GetSpeed()
        {
            return 60;
        }
        public void Eat()
        {
            Console.WriteLine("Cat eat fish.");
        }
        public void Drink()
        {
            Console.WriteLine("Cat drink water like human.");
        }
    }
}
