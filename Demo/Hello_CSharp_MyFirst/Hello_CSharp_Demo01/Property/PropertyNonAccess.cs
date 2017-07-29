using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Property
{
    class PropertyNonAccess
    {
        public string Name { get; set; }
        public string Code { get; }
        public PropertyNonAccess(string name, string code)
        {
            this.Name = name;
            this.Code = code;
        }

    }
}
