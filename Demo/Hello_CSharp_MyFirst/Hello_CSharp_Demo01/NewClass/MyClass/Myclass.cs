using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.MyClass
{
    class Myclass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Day la mot class moi");
            //Console.ReadLine();
            //Câu lệnh rẽ nhánh
            //Câu lệnh if else
            //if (5 > 10)
            //{
            //    Console.WriteLine("5 là số nhỏ hơn 10");
            //}
            //else
            //{
            //    Console.WriteLine("5 la so khong the lon hon 10");
            //    Console.ReadLine();
            //}
            //Kiểm tra độ tuổi của một người.
            int age;
            Console.WriteLine("Hãy nhập vào tuổi của bạn");
            string inputAge = Console.ReadLine();
            if (Int32.TryParse(inputAge, out age))
            {
                Console.WriteLine("Tuổi của bạn là:{0}", age);
                if (age == 0)
                {
                    Console.WriteLine("Bạn phải nhập vào tuổi thật của mình nhé :)");
                }
                else
                {
                    if (age > 0 && age < 20)
                    {
                        Console.WriteLine("Bạn là một người còn rất trẻ.");
                    }
                    else if (age >= 20 && age <= 30)
                    {
                        Console.WriteLine("Bạn là một người khá trẻ");
                    }
                    else if (age > 30 && age <= 50)
                    {
                        Console.WriteLine("Bạn là một người trung tuổi rồi đó.");
                    }
                    else
                    {
                        Console.WriteLine("Bạn là một người đã có tuổi rồi.");
                    }
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Tuoi nhap vao phai la so");
                Console.ReadLine();
            }
        }
    }
}
