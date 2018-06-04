using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested___IF_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 9, myVar2 = 6;
            if (myVar1 == 9)
            {
                Console.WriteLine("My Var1 == 9");
                if (myVar2 == 7)
                {
                    Console.WriteLine("My Var2 == 7");
                }
                else
                {
                    Console.WriteLine("My Var2 is not equal 7");
                }
            }
            else
            {
                Console.WriteLine("My Var1 is not equal 9");
            }
            Console.ReadKey();
        }
    }
}
