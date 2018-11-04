using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int mySalary = 1000, total = 0;
              for (int i = 0; i < 12; i++)
              {
                  total += mySalary;
              }
              Console.WriteLine("My Salary = {0}", total);
              Console.ReadKey();*/

            // Chalenge


            int mySalary = 1020;
            int Month = 0;
            int Year = 0;
            for (int i = 20; mySalary < 2000; Month++)
            {
                mySalary += i; // mySalary = mySalary + i;

                Year = Month / 12;
                
            }
            Console.WriteLine("My Salary = {0}", mySalary);
            Console.WriteLine("Number of Months = {0}", Month);
            Console.WriteLine("Number of Years = {0}", Year);
            Console.ReadKey();
        }
    }
}
