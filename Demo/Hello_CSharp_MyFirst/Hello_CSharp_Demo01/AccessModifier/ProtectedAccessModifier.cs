using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.AccessModifier
{
    class ProtectedAccessModifier
    {
        protected void ShowMe()
        {
            Console.WriteLine("Show me your skill code.");
        }
        protected static String Getinfor()
        {
            return "Protected Access Modifier";
        }
    }
}
