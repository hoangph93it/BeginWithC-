using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Field
{
    class FieldInCSharp
    {
        //Đây là một trường tĩnh
        public static int truong_tinh = 100;
        //Đây là một trường thông thường
        public string truong_thuong;
        //Khởi tạo một constuctor
        public FieldInCSharp(string value)
        {
            this.truong_thuong = value;
        }
        public const int my_int = 500;
        public static readonly DateTime My_date_time = DateTime.Now;
        public readonly DateTime My_Date_Time;
        public FieldInCSharp()
        {
            this.My_Date_Time = DateTime.Now;
        }
    }
}
