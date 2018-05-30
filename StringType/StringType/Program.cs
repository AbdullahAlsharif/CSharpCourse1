using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            // \' \" \\ \0(يدل على نهاية السترنق) \a(soundيطلع) \b(يحذف الحرف الأخير) \n(يعطي سطر جديد ودبل سلاش دبل ان سوف ينزل سطرين)
            //\r(يحذف السترنق التي قبله ويضع السترنق التي بعده فوقها) \t(يعطي مسافة تاب) \v(يعطي علامة استفهام) \f(يعطي علامة استفهام)

            string myString = "This is my \v \f  string variable";
            string myString1 = "Abdullah said\r This\b is args\n\n good\t cours\v, and I think\a";
            Console.WriteLine("{0}", myString);
            Console.WriteLine("{0}", myString1);

            //@ ( تستطيع طباعة أي نص ويخفي جميع الأخطاء إذا وضعتها قبل علامتي التنصيص أيضا إذا قسمت النص ونزلت سطر فلا تظهر أخطاء)
            string myString2 = @" A-Z Channal\ to learn\ 
                               C# for programmer";
            Console.WriteLine(myString2);

            // يمكن دمج أكثر من سترنق في وقت واحد كالتالي
            string myString3 = myString + myString1 + myString2;
            Console.WriteLine("{0}", myString3);
            Console.ReadKey();
        }
    }
}
