using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Generic
{
    public class PhoneKeyValueInherit : KeyValue<int, string>
    {
        public PhoneKeyValueInherit(int key, string value):base(key, value)
        {

        }
    }
}
