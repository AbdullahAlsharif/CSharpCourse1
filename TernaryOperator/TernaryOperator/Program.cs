using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 11;
            string myResult = (myVar < 10) ? "Less than 10" : "Grater than 10";
            //This means (If (myVar < 10) print the first one ("Less than 10"), If not print second one ("Grater than 10")
            Console.WriteLine("My Variable Result is {0}", myResult);

            // إذا كانت القيمة سترنق
            string myName = "Abdullah", result;
            result = (myName.Equals("Abdullah")) ? "(Yes)" : "(No)";
            Console.WriteLine("My Variable Result Is {0}", result);
            Console.ReadKey();
        }
    }
}
