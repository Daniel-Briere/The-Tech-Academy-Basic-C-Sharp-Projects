using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declared variable and initialized to zero.
            int num1 = 0;

            //Ask the user to type a number.
            Console.WriteLine("Type a number, then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Ask the user to choose and option.
            Console.WriteLine("Choose and option from the following list:");
            Console.WriteLine("\ta - plus 25");
            Console.WriteLine("\tm - multiplied by 50");
            Console.WriteLine("\td - divided by 12.5");
            Console.WriteLine("\tr - divided by 7");
            Console.WriteLine("\tg - is Greater then 50");
            Console.Write("Your option? ");

            //Use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + 25 = " + (num1 + 25));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * 50 = " + (num1 * 50));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / 12.5 = " + (num1 / 12.5));
                    break;
                case "r":
                    Console.WriteLine($"Your result: {num1} % 7 = " + (num1 % 7));
                    break;
                case "g":
                    Console.WriteLine($"Your result: {num1} > 50 = " + (num1 > 50));
                    break;
            }
            
            //Wait for user to respond before closing
            Console.Write("Press any key to close the math console app...");
            Console.ReadKey();
            
        }
    }
}
