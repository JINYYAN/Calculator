﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();

            Console.WriteLine($"3+5={calc.Add(3, 5)}");
            Console.WriteLine($"3-5={calc.Sub(3, 5)}");
            Console.WriteLine($"3*5={calc.Mul(3, 5)}");
            Console.WriteLine($"3/5={calc.Div(3, 5)}");

            Console.ReadKey();
        }
    }
}
