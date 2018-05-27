using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolType
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;
            char myVar = 'G';
            int myVarValue = 'G';

            char myVarValiue2 = Convert.ToChar(71);

            Console.WriteLine("Min Char = {0} Max Char ={1} My Caracter {2} My Variable Number {3} My Conversion Vale Is = {4}", 
                charMin, charMax, myVar, myVarValue, myVarValiue2);

            string myString = "This is My Variable";
            Console.WriteLine("\nMy String is {0}", myString);

            bool myBool = true;
            Console.WriteLine("My Boolean Value is {0}", myBool);

            int myVarValue3 = 'A';
            Console.WriteLine("My Variable Value3 {0}", myVarValue3);
            int myVarValue4 = 'a';
            Console.WriteLine("My Variable Value4 {0}", myVarValue4);

            string myString3 = "This is my character A value";
            Console.WriteLine("\nMy String3 is {0}", myString3);
            string myString4 = "This is my character a value";
            Console.WriteLine("\nMy String4 is {0}", myString4);

            Console.WriteLine("\nMy String3 is {0} My Variable value3 is {1} \nMy String4 is {2} My Variable Value4 is {3}",
                myString3, myVarValue3, myString4, myVarValue4);
            Console.ReadKey();
        }
    }
}
