﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1._77
{
    class Program
    {
        private static delegate TextWriter ConvarianceDel();

        static void Main(string[] args)
        {
            ConvarianceDel del;
            del = MethodStream;
            del = MethodString;
        }

        public static StreamWriter MethodStream() { return null; }
        public static StreamWriter MethodString() { return null; }
    }
}
