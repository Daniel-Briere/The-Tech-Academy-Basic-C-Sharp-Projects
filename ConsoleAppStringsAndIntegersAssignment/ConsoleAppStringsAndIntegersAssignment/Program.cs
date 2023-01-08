using System;
using System.Collections.Generic;

namespace ConsoleAppStringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of integers
            List<int> number = new List<int>();
            number.Add(74);
            number.Add(85);
            number.Add(99);
            number.Add(61);
            number.Add(32);
            //request user input
            Console.WriteLine("Enter a number to divide by.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            //trys to divide user input
            try
            {
                //for statment to go through each number in the list
                for (int i = 0; i < number.Count; i++)
                {
                    int result = number[i] / userInput;
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
            }
            //catch any error that occurs
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //message for when program emerges from try/catch block
            Console.WriteLine("Program passed the try/catch block.");
            Console.ReadLine();
        }
    }
}
