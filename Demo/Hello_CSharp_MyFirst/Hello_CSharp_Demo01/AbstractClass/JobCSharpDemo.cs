using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{
    public class JobCSharpDemo
    {
        public static void Main(string[] args)
        {
            CSharpCoding newcs = new CSharpCoding();
            newcs.DoJob();
            String newjob = newcs.GetJobName();
            Console.WriteLine("Get job new name:{0}", newjob);
            Console.ReadKey();
        }
    }
}
