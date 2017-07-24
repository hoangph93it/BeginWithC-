using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.ThuaKeTrongCSharp
{
    class Animal
    {
        public string Name;
        public Animal()
        {

        }
        public Animal(string name)
        {
            this.Name = name;
        }
        public virtual void Move()
        {
            Console.WriteLine("Animal move.");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }
}
