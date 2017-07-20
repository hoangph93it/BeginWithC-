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
            Class_Object_Instance hoangph = new Class_Object_Instance("Phan Huu Hoang");
            string name = hoangph.GetName();
            Console.WriteLine("Nguoi thu nhat la:{0}", name);
            Class_Object_Instance phuoctk = new Class_Object_Instance("Tran Kim Phuoc");
            string name2 = phuoctk.Name;
            Console.WriteLine("Ten nguoi thu 2 la:{0}", name2);
            Console.ReadLine();
        }
    }
}
