﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_CSharp_Demo01.Generic
{
    public class GenericInterfaceImpl<G> : InterfaceGenerics<G>
    {
        private G dosomething;
        public G DoSomeThing()
        {
            return dosomething;
        }
    }
}
