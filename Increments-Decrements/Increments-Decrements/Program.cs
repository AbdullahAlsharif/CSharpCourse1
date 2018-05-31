using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments_Decrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 2;
            int Temp1 = ++myVar1;
            // وضع علامة الجمع قبل المتغير تعني زيادة للقيمة بمقدار (1) فقط ++ أما وضعها بعد المتغير فلا يغير النتيجة
            Console.WriteLine("Temp1 = {0} ", Temp1);

            int myVar2 = 2;
            int Temp2 = --myVar2;
            // وكذلك وضع علامة الناقص قبل المتغير تنقص واحد من العدد
            Console.WriteLine("Temp2 = {0} ", Temp2);

            int myVar3 = 7;
            int myVar4 = 2;
            int Temp3 = myVar3-- / ++myVar4;
            Console.WriteLine("Temp3 = {0}", Temp3);
            Console.ReadKey();
        }
    }
}
