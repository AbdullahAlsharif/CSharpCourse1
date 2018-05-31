using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigenments_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            //=, +=, -=, *=, /=, %=,

            int myVar1 = 7, myVar2 = 3;
            // myVar1 = myVar2;
            // هنا قيمة المتغير الأول أعطيت قيمة المتغير الثاني 3 ولو عكسنا لصار العكس

            //myVar1 += myVar2;
            // (+=) تعني أن المتغير الأول يجمع مع المتغير الثاني

            //myVar1 -= myVar2;
            // (-=) تعني أن المتغير الأول يطرح منه المتغير الثاني

            //myVar1 *= myVar2;
            // (*=) تعني أن المتغير الأول يضرب في المتغير الثاني

            //myVar1 /= myVar2;
            // (/=) تعني أن المتغير الأول يقسم على المتغير الثاني

            myVar1 %= myVar2;
            // (%=) تعني باقي قسمة المتغير الأول  على المتغير الثاني

            Console.WriteLine("The result = {0} \n The myVar2 value = {1}", myVar1, myVar2);

            int myVar3 = 7, myVar4 = 2;
            myVar3 %= ++myVar4;
            Console.WriteLine("The result = {0} \n The myVar4 value = {1}", myVar3, myVar4);


            Console.ReadKey();

        }
    }
}
