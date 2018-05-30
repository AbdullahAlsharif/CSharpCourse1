using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //+ - / * % حيث أن علامة النسبة المؤية تعني باقي القسمة
            int myVar = 15;
            int myVar2 = 10;

            int Temp = myVar + myVar2;
            int Temp2 = myVar - myVar2;
            int Temp3 = myVar % myVar2;
            int Temp4 = myVar / myVar2;

            // + -
            int Temp5 = + myVar;
            int Temp6 = -myVar;

            string myStr = "This is Wonderful";
            string myStr2 = "How is it? ,";

            string myStr3 = myStr2 + myStr;
            Console.WriteLine("The result is {0} \nThe result2 is {1} \nThe result3 is {2} \nThe result4 is {3} \n plus {4} \n minus {5}",
                Temp, Temp2, Temp3, Temp4, Temp5, Temp6);
            Console.WriteLine("{0}", myStr3);
            Console.ReadKey();
                

        }
    }
}
