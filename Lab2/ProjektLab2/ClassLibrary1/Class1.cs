﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: AssemblyDelaySign(true)]
[assembly: AssemblyKeyFile(@".\public.snk")]


namespace TestLib1
{
    public class Class
    {
        public Class()
        { }
        public string Version
        {
            get
            {
                Assembly assembly = Assembly.GetAssembly(GetType());
                return assembly.GetName().Version.ToString();
            }
        }
    }
}
