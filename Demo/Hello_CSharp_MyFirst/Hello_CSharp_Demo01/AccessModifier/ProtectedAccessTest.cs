using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.AccessModifier
{
    class ProtectedAccessTest
    {
        public void Test()
        {
            ProtectedAccessModifier pro = new ProtectedAccessModifier();
            //pro.ShowMe(); error
            //pro.Getinfor(); error
        }
    }
    class ChildProtectedAccess : ProtectedAccessModifier

    {
        public void Test()
        {
            this.ShowMe();
            ProtectedAccessModifier.Getinfor();
        }
    }
}
