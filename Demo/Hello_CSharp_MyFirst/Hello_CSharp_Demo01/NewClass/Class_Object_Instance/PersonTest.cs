using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Class_Object_Instance
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            Class_Object_Instance hoangph = new Class_Object_Instance("phan huu hoang");
            string name = hoangph.GetName();
            Console.WriteLine("Nguoi thu nhat la:{0}", name);

            Console.ReadLine();
        }
    }
}
