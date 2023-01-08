using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class
            Integers integers = new Integers();
            //request one or two numbers from user
            Console.WriteLine("Enter a number.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter another number if you would like.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            //calling method from class
            integers.MathOp();
        }
    }
}
