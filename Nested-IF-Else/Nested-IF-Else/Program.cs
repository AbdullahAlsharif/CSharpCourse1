﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_IF_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 4, myVar2 = 6;
            if (myVar1 <= 3 && myVar2 >= 5)
            {
                Console.WriteLine("Condition one right");
            }
            else if (myVar1 <= 4 && myVar2 >= 6)
            {
                Console.WriteLine("Codition two right");
            }
            else if (myVar2 > 5) // هنا البرنامج سيتجاوز هذا الشرط لأنه تحقق الشرط الذي قبله وسينتقل إلى نهاية البرنامج
            {
                Console.WriteLine("Condition three right");
            }
            else
            {
                Console.WriteLine("No one of the conditions");
            }
            Console.ReadKey();
        }
    }
}
