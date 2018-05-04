﻿using System;
using InliningAnalyzer;

namespace JitHost.Core.x86
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            JitCompiler compiler = JitCompilerFactory.Create(args);
            compiler.PreJITMethods();
        }
    }
}
