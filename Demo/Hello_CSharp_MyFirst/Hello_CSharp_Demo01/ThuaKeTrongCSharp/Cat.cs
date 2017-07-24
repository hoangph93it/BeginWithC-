using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.ThuaKeTrongCSharp
{
    class Cat : Animal
    {
        public int Age;
        public int Weight;
        public Cat(string name, int age, int weight) : base(name)
        {
            this.Age = age;
            this.Weight = weight;
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Cat is moving...");
        }
        public void Say()
        {
            Console.WriteLine("Meo meo");
        }
    }
}
