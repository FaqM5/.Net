﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A("colman");
            B b = new B();
            a.M1();
            a.M2();
            a.M3();
            b.M1();
            b.M2();
            b.M3();
            b.M4();

        }
    }
}