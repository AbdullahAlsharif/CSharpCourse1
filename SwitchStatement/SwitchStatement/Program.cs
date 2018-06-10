using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string myAnimal = "Cat";
            switch (myAnimal)
            {
                case "Canary":
                    Console.WriteLine("My Animal Is a Canary Bird");
                    break;
                case "Cat":
                    Console.WriteLine("My Animal Is a Cat");
                    break;
                case "Camel":
                    Console.WriteLine("My Animal Is a Camel");
                    break;

                default:
                    Console.WriteLine("No one");
                    break;

            }

            int myVar = 18;
            switch (myVar)
            {
                case 10:
                    Console.WriteLine("My Value is 10");
                    break;
                case 7:
                    Console.WriteLine("My Value is 7");
                    break;
                case 15:
                    Console.WriteLine("My Value is 15");
                    break;

                default:
                    Console.WriteLine("No One");
                    break;

            }

            Console.ReadKey();
        }
    }
}
