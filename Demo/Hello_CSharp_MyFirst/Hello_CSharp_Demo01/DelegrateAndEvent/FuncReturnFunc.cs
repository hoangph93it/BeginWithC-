using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.DelegrateAndEvent
{
    class FuncReturnFunc
    {
        public delegate float TaxFomular(float salary);
        public static float UsaFomular(float salary)
        {
            return 10 * salary / 100;
        }
        public static float VnFomular(float salary)
        {
            return 5 * salary / 100;
        }
        public static float DefaultFomular(float salary)
        {
            return 7 * salary / 100;
        }
        public static TaxFomular GetSalaryFomula(string countryCode)
        {
            if (countryCode == "VN")
            {
                return FuncReturnFunc.VnFomular;
            }
            else if (countryCode == "US")
            {
                return FuncReturnFunc.UsaFomular;
            }
            return FuncReturnFunc.DefaultFomular;
        }
    }
}