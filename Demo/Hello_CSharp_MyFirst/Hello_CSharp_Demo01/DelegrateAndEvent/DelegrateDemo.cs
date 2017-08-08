using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.DelegrateAndEvent
{
    class DelegrateDemo
    {
        delegate int IntIntToInt(int a, int b);
        public static void Main(string[] args)
        {
            IntIntToInt iitoint = new IntIntToInt(DelegateCaculate.Sum);
            int sum = iitoint(10, 10);
            Console.WriteLine("The result of sum metheod:{0}", sum);
            IntIntToInt minusInt = new IntIntToInt(DelegateCaculate.Minus);
            int minus = minusInt(50, 10);
            Console.WriteLine("The result of minus method is:{0}", minus);
            IntIntToInt multipInt = new IntIntToInt(DelegateCaculate.Muntiple);
            int multiple = multipInt(30, 3);
            Console.WriteLine("The result of muntiple method is:{0}", multiple);
            IntIntToInt divideInt = new IntIntToInt(DelegateCaculate.Divide);
            int divide = divideInt(60, 10);
            Console.WriteLine("The result of divide method is:{0}", divide);
            Console.Read();
        }
    }
}
