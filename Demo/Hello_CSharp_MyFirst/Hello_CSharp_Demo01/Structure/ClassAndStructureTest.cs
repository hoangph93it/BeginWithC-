using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Structure
{
    class ClassAndStructureTest
    {
        private static void PassToMe(MyClass myclass, MyStructue mystructure)
        {
            myclass.Name = "C# Coding";
            mystructure.Name = "Coding C#";
        }
        public static void Main(string[] args)
        {
            MyClass myclass = new MyClass("C#");
            MyStructue mystructure = new MyStructue("Java");
            Console.WriteLine("Before pass to method");
            Console.WriteLine("The name of MyClass is:" + myclass.Name);
            Console.WriteLine("The name of MyStructure is:" + mystructure.Name);
            Console.WriteLine("After to pass method:");
            PassToMe(myclass, mystructure);
            Console.WriteLine("The name of MyClass is:" + myclass.Name);
            Console.WriteLine("The name of MyStructure is:" + mystructure.Name);
            Console.ReadKey();
        }
    }
}
