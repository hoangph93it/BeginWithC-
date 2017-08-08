using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.DelegrateAndEvent
{
    public class StringDelegrate
    {
        public string SayHello(string name)
        {
            return "Hello" + name;
        }
        public string SayHello(string FirstName, string LastName)
        {
            return "Hello" + FirstName + LastName;
        }
        public void Slient(string name)
        {

        }
    }
}
