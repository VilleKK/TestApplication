﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace TestApplication
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(MathLibrary.MathUtilities.Add(3, 4));
            Console.WriteLine(MathLibrary.MathUtilities.Add(3, 4));
            Console.WriteLine(MathLibrary.MathUtilities.Divide(3, 4));

            Console.WriteLine(MathLibrary.MathUtilities.Multiply(3, 4));

            Console.WriteLine(MathLibrary.MathUtilities.Subtract(3, 4));

        }
    }
}
