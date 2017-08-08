using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Exception
{
    public class AgeException : ApplicationException
    {
        public AgeException(string message) : base(message)
        {

        }

    }
    public class ToYoungException : AgeException
    {
        public ToYoungException(string message) : base(message)
        {

        }
    }
    public class ToOldException : AgeException
    {
        public ToOldException(string message) : base(message)
        {

        }
    }
}
