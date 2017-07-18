using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.NewClass.Class_Object_Instance
{
    class Class_Object_Instance
    {
        public string Name;
        public Class_Object_Instance(string personName)
        {
            this.Name = personName;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
