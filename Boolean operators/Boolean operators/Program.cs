using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean comparesio ==, !=, <, >, <=, >=
            // Boolean condition &&, ||
            bool MyResult;
            int myVar1 = 5, myVar2 = 8;

            // == هذه العلامة تعني المقارنة هل تساوي
            //MyResult = myVar1 == 5;

            // != هذه العلامة تعني لا تساوي
            // MyResult = myVar1 != 5;

            // (< less than , > more than, <= less than or equal , >= more than or equal)  

            // && هذه العلامة تعني المقارنة بين أكثر من متغير (و) ولكن حتى تكون النتيجة صحيحة يجب أن تكون المادلتين صحيحتين
           // MyResult = (myVar1 == 5) && (myVar2 == 8);

            // || هذه العلامة تعني المقارنة بين أكثر من متغير (أو) وحتى تكون النتيجة صحيحة يكفى أن تكون أحد المعادلات صحيحة
            MyResult = (myVar1 == 4) || (myVar2 == 8);

            Console.WriteLine("My result is = {0}", MyResult);
            Console.ReadKey();
        }
    }
}
