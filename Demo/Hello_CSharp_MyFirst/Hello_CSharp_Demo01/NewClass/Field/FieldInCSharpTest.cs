using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Field
{
    class FieldInCSharp_Test
    {
        public static void Main(string[] args)
        {
            //In ra giá trị của trường tĩnh.
            Console.WriteLine("Gia tri cua truong tinh la:{0}", FieldInCSharp.truong_tinh);
            //Thay doi gia tri cua truong tinh
            FieldInCSharp.truong_tinh = 2000;
            Console.WriteLine("____________________");
            FieldInCSharp obj_1 = new FieldInCSharp("Phan Huu Hoang");
            Console.WriteLine("obj_1.truong_thuong={0}", obj_1.truong_thuong);
            FieldInCSharp obj_2 = new FieldInCSharp("Tran Kim Phuoc");
            Console.WriteLine("obj_2.truong_thuong={0}", obj_2.truong_thuong);
            FieldInCSharp obj_3 = new FieldInCSharp();
            Console.WriteLine("Gia tri my int la:{0}", FieldInCSharp.my_int);
            Console.WriteLine("Gia tri ngay thang can lay:{0}", FieldInCSharp.My_date_time);
            Console.WriteLine("Ngay thang hien tai la:{0}", obj_3.My_Date_Time);
            Console.ReadLine();
        }
    }
}
