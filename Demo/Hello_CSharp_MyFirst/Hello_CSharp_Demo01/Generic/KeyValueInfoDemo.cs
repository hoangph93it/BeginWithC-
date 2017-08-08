using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Generic
{
    public class KeyValueInfoDemo
    {
        public static void Main(string[] args)
        {
            KeyValueInfo<int, string, string> student = new KeyValueInfo<int, string, string>(1, "Phan Huu Hoang", "Da tot nghiep dai hoc");
            int id = student.GetKey();
            string name = student.GetValue();
            string infomation = student.GetInfo();
            Console.WriteLine("This is all information of the student:" + " id: " + id + "; name: " + name + "; infomaiton: " + infomation);
            Console.ReadKey();
        }
    }
}
