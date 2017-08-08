using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Structure
{
    class StructureTest
    {
        public static void Main(string[] args)
        {
            StructureEmployee em = new StructureEmployee(1, "Phan Huu Hoang", "Coder");
            Console.WriteLine("ID for employee is:" + em.ID);
            Console.WriteLine("The name employee is:" + em.Name);
            Console.WriteLine("Position of employee is:" + em.Position);
            Console.Read();
        }
    }
}
