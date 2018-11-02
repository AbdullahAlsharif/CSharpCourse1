using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 0;
            double mySalary = 1020.30, total = 0.0;
            while(i<15)
                {
                 total += mySalary;
                i++;
                
            }
            Console.WriteLine("My Salary is {0}", total);
            Console.ReadKey();*/
            /*
           int i = 0;
           int myWeight = 120;
           while (myWeight > 80)
           {
               myWeight--;
               i++;
           }
           Console.WriteLine("Number of Exercises is {0}", i);
           Console.ReadKey();*/

            int Exersices = 0;
            double waigth = 120.0, total = 0.0;
            while (waigth > 83)
            {
                waigth--;
                Exersices++;

            }
            Console.WriteLine("Number of Exercises is {0}", Exersices);
            Console.ReadKey();
        }

    }
}
