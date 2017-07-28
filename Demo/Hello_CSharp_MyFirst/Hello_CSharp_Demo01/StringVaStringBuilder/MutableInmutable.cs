using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.StringVaStringBuilder
{
    class MutableInmutable
    {

    }
    class Mutable
    {
        private int Value;
        public Mutable(int value)
        {
            this.Value = value;
        }
        public void NewValue(int newvalue)
        {
            this.Value = newvalue;
        }
    }
    class Inmuatable
    {
        private string Name;
        private int Value;
        public Inmuatable(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }
        public String GetName()
        {
            return Name;
        }
        public int GetValue()
        {
            return Value;
        }
    }
}
