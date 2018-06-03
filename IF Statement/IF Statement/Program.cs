using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int myVar = 10;
            /* if (myVar == 11)
                 Console.WriteLine("My Variable Equal 10"); // إذا تحقق الشرط يطبع هذه العبارة
             else
                 Console.WriteLine("My Variable is not Equal 10"); // إذا لم يتحقق الشرط يطبع هذه العبارة
                 */

            /*
            // إذا كانت الإف تحتوي على أكثر من جملة نجعل الجمل بين مقكوفات {}
            if (myVar == 10)
            {
                myVar = 11;
                Console.WriteLine("{0}", myVar);
                Console.WriteLine("My Variable Equal 10");
            }
            else
                Console.WriteLine("My Variable is not Equal 10");
            // هذا مثال عندما يكون لدينا شرط واحد
            */

            /*
            // والمثال التالي عندما يكون لدينا أكثر من شرط
            int myVar1 = 9, myVar2 = 7;

            if ((myVar1 <= 9) || (myVar2 >= 7)) 
            {
                Console.WriteLine("The Condition Is True");
            }

            else
            {
                Console.WriteLine("The Condition Is False");
            }
            */


            // If we have multy (IF):
            int myVar = 11;
            string myResult;
            if (myVar < 10)
            {
                myResult = "Less than 10";
                Console.WriteLine(myResult);
            }

            if (myVar > 10)
            {
                myResult = "Grater than 10";
                Console.WriteLine(myResult);
            }

            if (myVar == 10)
            {
                myResult = "Equal 10";
                Console.WriteLine(myResult);
            }

            Console.ReadKey();
        }
    }
}
