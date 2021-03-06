﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kernel.Module.Test.Common.Interfaces;

namespace Kernel.Module.TestModule2
{
    public class MyInterfacedClassByInterfaceInheritence : IMyModuleInterfaceByInheritence
    {
        private string _last;

        public string ToLower(string str)
        {
            _last =str.ToLower();
            return _last;
        }

        public string Last
        {
            get { return _last; }
        }
    }
}
