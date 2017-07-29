using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Property
{
    class PropertyInterfaceInherit : PropertyInterface
    {
        private string color;
        public string Color
        {
            get { return this.color; }
        }
        public PropertyInterfaceInherit(String color)
        {
            this.color = color;
        }
    }
}
