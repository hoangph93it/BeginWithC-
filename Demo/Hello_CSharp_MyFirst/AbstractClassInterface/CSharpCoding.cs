using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{
    public class CSharpCoding : AbstractJob
    {
        public CSharpCoding()
        {

        }
        public override void DoJob()
        {
            Console.WriteLine("Do this job");
        }
        public override string GetJobName()
        {
            return "CSharp coding";
        }
        public void RunExample()
        {
            Console.WriteLine("Running Example");
        }

    }
}
