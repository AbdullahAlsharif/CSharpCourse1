using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {

            /*double MySalary = 1000.2, total = 0.0;
            int i = 0;
            do
            {
                total += MySalary; //total = total + MySalary
                i++;
                Console.WriteLine("i value equal {0}", i);
            } while (i < 10);
            Console.WriteLine("Salary value equal {0}", total);
            Console.ReadKey();*/

            //حل التحدي
            double mySalary = 1020.0;
            int i = 20;
            int Month = 0;
            int Year = 0;
            do
            {
                mySalary += i; // mySalary = mySalary + i;
                Month++;
                Year = Month / 12;
                Console.WriteLine("Salary Values equal {0}", mySalary);

            }
            while (mySalary < 2000);

            
            Console.WriteLine("\nTotal of Months are {0} \nTotal of Years are {1}", Month, Year);


            Console.ReadKey();
        }
    }
}
