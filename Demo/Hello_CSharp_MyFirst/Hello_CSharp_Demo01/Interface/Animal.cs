using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Interface
{
    public abstract class Animal : MyInterface
    {
        public void Run()
        {
            Console.WriteLine("Animal running...");
        }
        public abstract void Back();

        public abstract int GetSpeed();
    }
}
