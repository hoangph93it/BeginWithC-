using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Structure
{
    public struct StructureEmployee
    {
        public int ID;
        public string Name;
        public string Position;
        public StructureEmployee(int ID, string Name, string Position)
        {
            this.ID = ID;
            this.Name = Name;
            this.Position = Position;
        }
    }
}
