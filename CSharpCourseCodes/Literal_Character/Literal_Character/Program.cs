﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 100;
            uint myUVar = 1000U;
            

            float myFlVar = 1.5F;
            double myDVar = 100.5D;
            decimal myDecVar = 100.5M;

            Console.WriteLine("{0} {1}", myVar, myUVar);
            Console.WriteLine($"{myFlVar}, {myDVar}, {myDecVar}");
            Console.ReadKey();


        }
    }
}
