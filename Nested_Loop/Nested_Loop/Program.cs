using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for (int i=0; i<3; i++)
             {
                 Console.WriteLine("Hello Abdullah");
                 for (int j=0; j<2; j++)
                 {
                     Console.WriteLine("\t Hello World");
                 }
                 Console.WriteLine("\n");
             }*/

            for (int i=1; i<=5; i++)
            {
                
                
                for (int j=1; j<=10; j++)
                {
                    
                    Console.WriteLine("The Multible Index is {0}*{1}={2}", i, j, i*j);
                }
                Console.WriteLine("\n");

            }

            /* for (int i = 1; i <= 6; i++)
             {


                 for (int j = 2; j <= 10; j+=2)
                 {

                     Console.WriteLine("The Even Numbers is {0}*{1}={2}", i, j, i*j);
                 }
                 Console.WriteLine("\n");

             }*/


            /*for (int i = 1; i <= 6; i++)
            {


                for (int j = 1; j <= 10; j += 2)
                {

                    Console.WriteLine("The Odd Numbers is {0}*{1}={2}", i, j, i * j);
                }
                Console.WriteLine("\n");

            }*/
            Console.ReadKey();
        }
    }
}
