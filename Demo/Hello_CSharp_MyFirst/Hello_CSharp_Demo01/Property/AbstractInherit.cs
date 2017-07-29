using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Property
{
    class AbstractInherit : AbstractProperty

    {
        private string name;
        private string code;
        public override string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }
        public override string Code
        {
            get
            {
                return this.code;
            }
        }
        public AbstractInherit(string name, string code)
        {
            this.name = name;
            this.code = code;
        }
    }
}
