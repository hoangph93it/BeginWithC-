using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.KeThua_DaHinh
{
    class PersonTest
    {
        public static void Main(string[] args)
        {
            Class_Constructor_Object my_person = new Class_Constructor_Object("PHAN HUU HOANG", 1993, "Vinh Tuong - Vinh Phuc");
            Console.WriteLine("My info:");
            Console.WriteLine("Name:{0}", my_person.PersonName);
            Console.WriteLine("DOB:{0}", my_person.DOB);
            Console.WriteLine("POB:{0}", my_person.POB);
            Console.ReadLine();
        }
    }
}
