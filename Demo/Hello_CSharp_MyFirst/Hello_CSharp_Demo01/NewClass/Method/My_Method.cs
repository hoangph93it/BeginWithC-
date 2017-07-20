using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Method
{
    class My_Method
    {
        public string my_text = "Some text in here";
        public My_Method()
        {

        }
        public string GetText()
        {
            return this.my_text;
        }
        public void Set_Text(string txt_my)
        {
            this.my_text = txt_my;
        }
        public static int Sum(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        }

    }
}
