﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 12345.678;
            int i;

            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
