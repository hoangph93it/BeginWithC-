using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.KeThua_DaHinh
{
    class Class_Constructor_Object
    {
        public string PersonName;
        public int DOB;
        public string POB;
        public Class_Constructor_Object(string person_name, int dob, string pob)
        {
            this.PersonName = person_name;
            this.DOB = dob;
            this.POB = pob;
        }

    }
}
