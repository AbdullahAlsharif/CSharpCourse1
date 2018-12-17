using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakLoop_ContinuCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for (int i=0; i<=5; i++)
             {
                 Console.WriteLine("Hellow Abdullah");
                 if (i > 2)
                     continue;
                 for (int j = 0; j <= 4; j++)
                 {
                     Console.WriteLine("\t Hellow World");
                 }
                 Console.WriteLine("\n");
             }
             Console.ReadLine();*/


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\t The value of i = {0}", i);
                if (i > 7)
                    continue;

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("\n The result of {0}*{1}={2}", i, j, i * j);
                }
                Console.WriteLine("\t");

            }
            Console.ReadKey();
        }
    }
}
