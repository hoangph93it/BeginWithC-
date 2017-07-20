using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Method
{
    class My_Method_Test
    {
        public static void Main(string[] args)
        {
            My_Method obj = new My_Method();
            string my_text = obj.GetText();
            Console.WriteLine("Gia tri my text la:{0}", my_text);
            obj.Set_Text("Noi dung text moi");
            Console.WriteLine("Noi dung cua text moi la:{0}", obj.GetText());
            int sum = My_Method.Sum(20,10,10);
            Console.WriteLine("Tong la:{0}", sum);
            Console.ReadLine();
        }
    }
}
