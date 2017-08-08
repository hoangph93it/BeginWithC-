using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.DelegrateAndEvent
{
    class FomulaDemo
    {
        public static void Main(string[] args)
        {
            float salary = 1000f;
            FuncReturnFunc.TaxFomular fomula = FuncReturnFunc.GetSalaryFomula("VN");
            float tax = fomula(salary);
            Console.WriteLine("Tax in Viet Nam is: {0}", tax);
            fomula = FuncReturnFunc.GetSalaryFomula("US");
            tax = fomula(salary);
            Console.WriteLine("Tax in US is: {0}", tax);
            Console.Read();
        }
    }
}