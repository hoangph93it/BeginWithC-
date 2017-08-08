using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Generic
{
    public class StringAndValueEntry<V> : KeyValue<int, V>
    {
        public StringAndValueEntry(int key, V value) : base(key, value)
        {
        }
    }
}
