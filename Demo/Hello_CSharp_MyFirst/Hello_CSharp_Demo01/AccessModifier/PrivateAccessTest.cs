using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.AccessModifier
{
    class PrivateAccessTest
    {
        public static void Main(string[] args)
        {
            PrivateAccessModifier my_acc = new PrivateAccessModifier("Private Access");
            //string name = my_acc.Name; error
            //my_acc.ShowSecret(); error
            //PrivateAccessModifier.doDoSomething(); error
           // PrivateAccessModifier rank = new PrivateAccessModifier(100); error
        }
    }
}
