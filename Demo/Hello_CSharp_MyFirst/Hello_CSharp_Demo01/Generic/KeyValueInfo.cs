using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Generic
{
    public class KeyValueInfo<K, V, I> : KeyValue<K, V>
    {
        private I info;
        public KeyValueInfo(K key, V value) : base(key, value)
        {

        }
        public KeyValueInfo(K key, V value, I info) : base(key, value)
        {
            this.info = info;
        }
        public I GetInfo()
        {
            return info;
        }
        public void SetInfo(I info)
        {
            this.info = info;
        }
    }
}
