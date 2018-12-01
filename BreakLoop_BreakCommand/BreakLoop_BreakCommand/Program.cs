using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakLoop_BreakCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for (int i=0; i<=5; i++)
             {
                 if (i > 2)
                     break;
                 Console.WriteLine("Hello Abdullah");
                 for (int j=0; j<=4; j++)
                 {
                     Console.WriteLine("\t Hello World");
                 }
                 Console.WriteLine("\n");

             }
             Console.ReadKey();*/

            for (int i = 1; i <= 10; i++)
            {
                if (i > 7)
                    break;
                
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("\n The result of {0}*{1}={2}", i, j, i*j);
                }
                Console.WriteLine("\t");

            }
            Console.ReadKey();
        }
    }
}
