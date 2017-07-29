using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Property
{
    class PropertyTest
    {
        public static void Main(string[] args)
        {
            CSharpProperty proper = new CSharpProperty("CSharp", "C#001");
            Console.WriteLine("The name code is: " + proper.Name);
            proper.Code = "C#002";
            Console.WriteLine("The new code is: " + proper.Code);

            PropertyNonAccess prononac = new PropertyNonAccess("Java", "J001");
            //prononac.Code = "";
            Console.WriteLine("The new name and code is:" + prononac.Name + " and " + prononac.Code);
            AbstractInherit abinher = new AbstractInherit("PHP", "P001");
            Console.WriteLine("Abstract property is:" + abinher.Name);
            //abinher.Code = "";
            Console.ReadKey();

        }
    }
}
