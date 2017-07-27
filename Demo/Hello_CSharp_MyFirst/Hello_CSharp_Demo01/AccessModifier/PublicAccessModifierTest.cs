using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.AccessModifier
{
    class PublicAccessModifierTest
    {
        public void Test()
        {
            Console.WriteLine("My number is:{0}", PublicAccessModifier.My_Number);
            PublicAccessModifier my_pub = new PublicAccessModifier();
            my_pub.My_Field = 2000;
            my_pub.My_Method();
        }
    }
}
